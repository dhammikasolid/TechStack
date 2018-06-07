using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAndDapper
{
    public class DbContextA: DbContext
    {
        public DbContextA() : base("EF")
        {

        }

        public DbSet<EntityWithCommonDataAnnotations> EntityWithCommonDataAnnotations { get; set; }
    }
}
