using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class trainingsessionMap : EntityTypeConfiguration<trainingsession>
    {
        public trainingsessionMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.endDate)
                .HasMaxLength(255);

            this.Property(t => t.startDate)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("trainingsession", "bank");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.endDate).HasColumnName("endDate");
            this.Property(t => t.startDate).HasColumnName("startDate");
        }
    }
}
