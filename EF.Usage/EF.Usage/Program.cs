using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EF.Usage
{
    public class Program
    {
        public static void Run()
        {
            Database.SetInitializer(new EmployeeDbInitializer());

            using (var db = new EmployeeDbContext())
            {
                var employees = db.Employees.ToList();
            }
        }
    }
}
