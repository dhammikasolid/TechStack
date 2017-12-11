using EF.Usage;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class QueryTests: IDisposable
    {
        EmployeeDbContext db;

        public QueryTests()
        {
            Database.SetInitializer(new EmployeeDbInitializer());
            db = new EmployeeDbContext();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        [Fact]
        public void FlattenResult_Test()
        {
            var query = from empoyee in db.Employees
                        select new
                        {
                            EmlpyeeId = empoyee.Id,
                            DepartmentId = empoyee.Department.Id,
                            CompanyId = empoyee.Department.Company.Id,
                            EmlpyeeName = empoyee.FirstName,
                            DepartmentName = empoyee.Department.Name,
                            CompanyName = empoyee.Department.Company.Name,
                        };

            var type = query.GetType();

            var results = query.ToList();
        }

        [Fact]
        public void TreeResult_Test()
        {
            var query = from company in db.Companies
                        select new
                        {
                            CompanyId = company.Id,
                            CompanyName = company.Name,
                            Departments = 
                            ( 
                                from department in company.Departments
                                where department.Budget > 350000
                                select new
                                {
                                    DepartmentId = department.Id,
                                    DepartmentName = department.Name,
                                    DepartmentBudget = department.Budget,
                                    Employees = 
                                    (
                                        from employee in department.Employees
                                        where employee.Salery > 110000
                                        orderby employee.Id descending
                                        select new
                                        {
                                            EmployeeId = employee.Id,
                                            EmployeeName = employee.FirstName,
                                            EmployeeSalery = employee.Salery
                                        }
                                    )
                                }
                            )
                        };

            var results = query.ToList();
        }

        [Fact]
        public void LazyLoading_Test()
        {
            //var query = from department in db.Departments
            //            select department;

            foreach (var department in db.Departments.ToList())
            {
                foreach (var employee in department.Employees)
                {

                }
            }
        }
    }
}
