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
    public class RelationshipsTests: IDisposable
    {
        EmployeeDbContext db;

        public RelationshipsTests()
        {
            Database.SetInitializer(new EmployeeDbInitializer());
            db = new EmployeeDbContext();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        [Fact]
        public void Many2Many_Test()
        {
            var employee = new Employee { Id = 1 };
            db.Employees.Attach(employee);

            var addingJobRole = new JobRole { Id = 2 };
            db.JobRoles.Attach(addingJobRole);

            employee.JobRoles = new List<JobRole> { addingJobRole };

            db.SaveChanges();

            db.Entry(employee).Reload();
        }
    }
}
