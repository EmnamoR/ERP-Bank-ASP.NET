using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class localMap : EntityTypeConfiguration<local>
    {
        public localMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.city)
                .HasMaxLength(255);

            this.Property(t => t.region)
                .HasMaxLength(255);

            this.Property(t => t.typeLocal)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("local", "bank");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.region).HasColumnName("region");
            this.Property(t => t.typeLocal).HasColumnName("typeLocal");
        }
    }
}
