using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class candidatureMap : EntityTypeConfiguration<candidature>
    {
        public candidatureMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.cv)
                .HasMaxLength(255);

            this.Property(t => t.email)
                .HasMaxLength(255);

            this.Property(t => t.lastName)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            this.Property(t => t.role)
                .HasMaxLength(255);

            this.Property(t => t.state)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("candidature", "bank");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.cv).HasColumnName("cv");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.lastName).HasColumnName("lastName");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.role).HasColumnName("role");
            this.Property(t => t.state).HasColumnName("state");
        }
    }
}
