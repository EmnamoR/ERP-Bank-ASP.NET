using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Data.Models.Mapping;
using Domain;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Data.Models
{
    public partial class bankContext : IdentityDbContext<User>
    {
        static bankContext()
        {
            Database.SetInitializer<bankContext>(null);
        }

        public bankContext()
            : base("Name=bankContext")
        {
        }

        public DbSet<candidature> candidatures { get; set; }
        public DbSet<contract> contracts { get; set; }
        public DbSet<employee> employees { get; set; }
        public DbSet<local> locals { get; set; }
        public DbSet<material> materials { get; set; }
        public DbSet<meeting> meetings { get; set; }
        public DbSet<payroll> payrolls { get; set; }
        public DbSet<supplier> suppliers { get; set; }
        public DbSet<trainingsession> trainingsessions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new candidatureMap());
            modelBuilder.Configurations.Add(new contractMap());
            modelBuilder.Configurations.Add(new employeeMap());
            modelBuilder.Configurations.Add(new localMap());
            modelBuilder.Configurations.Add(new materialMap());
            modelBuilder.Configurations.Add(new meetingMap());
            modelBuilder.Configurations.Add(new payrollMap());
            modelBuilder.Configurations.Add(new supplierMap());
            modelBuilder.Configurations.Add(new trainingsessionMap());
            base.OnModelCreating(modelBuilder);
        }
        public static bankContext Create()
        {
            return new bankContext();
        }
    }
}
