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
    public class DataModifyTests: IDisposable
    {
        EmployeeDbContext db;

        public DataModifyTests()
        {
            Database.SetInitializer(new EmployeeDbInitializer());
            db = new EmployeeDbContext();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        [Fact]
        public void Add_Test()
        {
            var addingCompany = new Company { Name = "C 100" };

            db.Companies.Add(addingCompany);

            db.SaveChanges();

            var addedCompany = (from company in db.Companies
                                where company.Name.Contains("C 100")
                                select company)
                               .FirstOrDefault();
        }

        [Fact]
        public void Remove_Test()
        {
            var addingCompany = new Company { Name = "C 100" };

            db.Companies.Add(addingCompany);

            db.SaveChanges();

            var addedCompany = (from company in db.Companies
                                where company.Name.Contains("C 100")
                                select company)
                               .FirstOrDefault();

            var removingCompany = db.Companies.Find(addedCompany.Id);

            db.Companies.Remove(removingCompany);

            db.SaveChanges();

            var removedCompany = db.Companies.Find(addedCompany.Id);
        }

        [Fact]
        public void RemoveByNotLoading1_Test()
        {
            var removingEmployeeStub = new Employee { Id = 4 };

            db.Employees.Attach(removingEmployeeStub);
            db.Employees.Remove(removingEmployeeStub); // Change entity state to EntityState.Deleted

            db.SaveChanges();

            var removedEmployee = db.Employees.Find(4);
        }

        [Fact]
        public void RemoveByNotLoading2_Test()
        {
            var removingEmployeeStub = new Employee { Id = 4 };

            db.Entry(removingEmployeeStub).State = EntityState.Deleted;

            db.SaveChanges();

            var removedEmployee = db.Employees.Find(4);
        }

        [Fact]
        public void Update_Test()
        {
            var updatingEmployeeStub = new Employee { Id = 4, FirstName = "Updated ***" };

            db.Entry(updatingEmployeeStub).State = EntityState.Unchanged;
            //db.Employees.Attach(updatingEmployeeStub); // Set state to EntityState.Unchanged
            db.Entry(updatingEmployeeStub).Property(p => p.FirstName).IsModified = true;

            db.SaveChanges();

            db.Entry(updatingEmployeeStub).Reload();
        }
    }
}
