using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EF
{
    using Models;

    public class SchoolDbContext: DbContext
    {
        public SchoolDbContext() : base("SchoolDbConnectionOffice")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
    }
}
