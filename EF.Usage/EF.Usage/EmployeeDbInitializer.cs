using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EF.Usage
{
    class EmployeeDbInitializer : DropCreateDatabaseAlways<EmployeeDbContext>
    {
        public override void InitializeDatabase(EmployeeDbContext context)
        {
            base.InitializeDatabase(context);

            context.Employees.Add(new Employee
            {
                FirstName = "E",
                LastName = "A"
            });

            context.SaveChanges();
        }
    }
}
