using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EF
{
    using Models;

    public class SchoolDbInitializer : DropCreateDatabaseAlways<SchoolDbContext>
    {
        public override void InitializeDatabase(SchoolDbContext db)
        {
            base.InitializeDatabase(db);

            var s1 = new Student { Name = "S1" };
            var s2 = new Student { Name = "S2" };
            var s3 = new Student { Name = "S3" };
            var s4 = new Student { Name = "S4" };

            var c1 = new Class
            {
                Name = "C1",
                Students1 = new List<Student> { s1, s2 },
            };
            var c2 = new Class
            {
                Name = "C2",
                Students1 = new List<Student> {s3, s4 },
            };

            db.Classes.AddRange(new List<Class> { c1, c2 });

            var t1 = new Teacher { Name = "T1" };
            var t2 = new Teacher { Name = "T2" };
            var t3 = new Teacher { Name = "T3" };
            var t4 = new Teacher { Name = "T4" };

            c1.Teachers = new List<ClassTeacher>
            {
                new ClassTeacher { Teacher = t1 },
                new ClassTeacher { Teacher = t2 },
                new ClassTeacher { Teacher = t3 },
            };
            c2.Teachers = new List<ClassTeacher>
            {
                new ClassTeacher { Teacher = t1 },
                new ClassTeacher { Teacher = t2 },
                new ClassTeacher { Teacher = t4 },
            };

            db.SaveChanges();
        }
    }
}
