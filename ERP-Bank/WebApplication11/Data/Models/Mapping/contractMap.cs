using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class contractMap : EntityTypeConfiguration<contract>
    {
        public contractMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.contractType)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("contract", "bank");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.contractType).HasColumnName("contractType");
            this.Property(t => t.endDate).HasColumnName("endDate");
            this.Property(t => t.startDate).HasColumnName("startDate");
            this.Property(t => t.employee_id).HasColumnName("employee_id");

            // Relationships
            this.HasOptional(t => t.employee)
                .WithMany(t => t.contracts)
                .HasForeignKey(d => d.employee_id);

        }
    }
}
