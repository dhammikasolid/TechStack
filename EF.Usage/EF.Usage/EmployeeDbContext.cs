using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Usage
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext() : base("office")
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
