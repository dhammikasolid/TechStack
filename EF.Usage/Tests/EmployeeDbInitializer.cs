using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using EF.Usage;

namespace Tests
{
    class EmployeeDbInitializer : DropCreateDatabaseAlways<EmployeeDbContext>
    {
        public override void InitializeDatabase(EmployeeDbContext context)
        {
            base.InitializeDatabase(context);

            Populate(context);

            context.SaveChanges();
        }

        void Populate(EmployeeDbContext context)
        {
            var companies = new List<Company>
            {
                new Company { Name = "C1" },
                new Company { Name = "C2" },
            };

            var departments = new List<Department>
            {
                new Department { Name = "constructor", Budget = 500000, Company = companies[0] },
                new Department { Name = "fixture", Budget = 400000, Company = companies[1] },
                new Department { Name = "instance", Budget = 350000, Company = companies[0] },
            };

            var jobRoles = new List<JobRole>
            {
                new JobRole { Name = "Role A" },
                new JobRole { Name = "Role B" },
                new JobRole { Name = "Role C" },
                new JobRole { Name = "Role D" },
            };

            var employees = new List<Employee>
            {
                new Employee
                {
                    FirstName = "when",
                    LastName = "you",
                    BirthDate = new DateTime(1988, 11, 12),
                    Salery = 150000,
                    Department = departments[0],
                    JobRoles = new List<JobRole> { jobRoles[0], jobRoles[3] }
                },
                new Employee
                {
                    FirstName = "want",
                    LastName = "create",
                    BirthDate = new DateTime(1989, 11, 12),
                    Salery = 120000,
                    Department = departments[1],
                    JobRoles = new List<JobRole> { jobRoles[1], jobRoles[2] }
                },
                new Employee
                {
                    FirstName = "single",
                    LastName = "test",
                    BirthDate = new DateTime(1990, 11, 12),
                    Salery = 110000,
                    Department = departments[1],
                    JobRoles = new List<JobRole> { jobRoles[0] }
                },
                new Employee
                {
                    FirstName = "context",
                    LastName = "and",
                    BirthDate = new DateTime(1991, 11, 12),
                    Salery = 120000,
                    Department = departments[2],
                    JobRoles = new List<JobRole> { jobRoles[3] }
                },
                new Employee
                {
                    FirstName = "share",
                    LastName = "among",
                    BirthDate = new DateTime(1992, 11, 12),
                    Salery = 150000,
                    Department = departments[0],
                    JobRoles = new List<JobRole> { jobRoles[0], jobRoles[3], jobRoles[2] }
                },
                new Employee
                {
                    FirstName = "all",
                    LastName = "tests",
                    BirthDate = new DateTime(2000, 11, 12),
                    Salery = 90000,
                    Department = departments[1]
                },
                new Employee
                {
                    FirstName = "Sometimes",
                    LastName = "context",
                    BirthDate = new DateTime(2002, 11, 12),
                    Salery = 120000,
                    Department = departments[2],
                    JobRoles = new List<JobRole> { jobRoles[0], jobRoles[3], jobRoles[2], jobRoles[1] }
                },
                new Employee
                {
                    FirstName = "creation",
                    LastName = "cleanup",
                    BirthDate = new DateTime(2004, 11, 12),
                    Salery = 150000,
                    Department = departments[2]
                },
            };

            context.Employees.AddRange(employees);
        }
    }
}
