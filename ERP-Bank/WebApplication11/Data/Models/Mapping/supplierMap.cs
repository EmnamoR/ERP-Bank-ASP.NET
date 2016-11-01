using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class supplierMap : EntityTypeConfiguration<supplier>
    {
        public supplierMap()
        {
            // Primary Key
            this.HasKey(t => t.id_supp);

            // Properties
            this.Property(t => t.id_supp)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.adress)
                .HasMaxLength(255);

            this.Property(t => t.email)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("supplier", "bank");
            this.Property(t => t.id_supp).HasColumnName("id_supp");
            this.Property(t => t.adress).HasColumnName("adress");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.name).HasColumnName("name");
        }
    }
}
