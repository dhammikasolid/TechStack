using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Data.Entity;

using EF.Usage;

namespace Tests
{
    public class EmployeeQueryTests : IDisposable
    {
        EmployeeDbContext db;

        public EmployeeQueryTests()
        {
            Database.SetInitializer(new EmployeeDbInitializer());
            db = new EmployeeDbContext();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        [Fact]
        public void Select_Test()
        {
            var employees = (
                    from employee in db.Employees
                    orderby employee.Salery
                    select employee 
                ).ToList();
        }
    }
}
