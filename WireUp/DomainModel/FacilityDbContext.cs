using System.Data.Entity;

namespace DomainModel
{
    public class FacilityDbContext : DbContext
    {
        public DbSet<Facility.Facility> Facilities { get; set; }
    }
}
