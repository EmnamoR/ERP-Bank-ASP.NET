using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class materialMap : EntityTypeConfiguration<material>
    {
        public materialMap()
        {
            // Primary Key
            this.HasKey(t => t.idMat);

            // Properties
            this.Property(t => t.idMat)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.designation)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("material", "bank");
            this.Property(t => t.idMat).HasColumnName("idMat");
            this.Property(t => t.designation).HasColumnName("designation");
            this.Property(t => t.quantite).HasColumnName("quantite");
            this.Property(t => t.local_id).HasColumnName("local_id");
            this.Property(t => t.supplier_id_supp).HasColumnName("supplier_id_supp");

            // Relationships
            this.HasOptional(t => t.local)
                .WithMany(t => t.materials)
                .HasForeignKey(d => d.local_id);
            this.HasOptional(t => t.supplier)
                .WithMany(t => t.materials)
                .HasForeignKey(d => d.supplier_id_supp);

        }
    }
}
