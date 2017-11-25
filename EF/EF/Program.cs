using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    using Models;
    using System.Data.Entity;

    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new SchoolDbInitializer());

            using (var db = new SchoolDbContext())
            {
                var c1 = db.Classes
                    .Where(c => c.Name == "C1")
                    .FirstOrDefault();

                var t1 = db.Entry(c1)
                    .Collection(c => c.Teachers)
                    .Query()
                    .Where(t => t.Teacher.Name == "T1")
                    .FirstOrDefault();
            }
        }
    }
}
