using Interview.Pharmacy.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Interview.Pharmacy.Database
{
    public class PharmacyDbContext
        : DbContext
    {
        public virtual DbSet<Models.Pharmacy> Pharmacies { get; set; }
        public virtual DbSet<Medicine> Medicines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Models.Pharmacy>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Medicine>()
                .HasKey(x => x.Id);
        }
    }
}
