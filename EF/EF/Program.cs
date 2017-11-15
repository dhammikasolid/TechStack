using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    using Models;

    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SchoolDbContext())
            {
                var _class = new Class
                {
                    Name = "C1",
                };

                db.Classes.Add(_class);
                db.SaveChanges();

                var query = from c in db.Classes
                            select c;

                var count = query.Count();
            }
        }
    }
}
