using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class payrollMap : EntityTypeConfiguration<payroll>
    {
        public payrollMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.endDate)
                .HasMaxLength(255);

            this.Property(t => t.startDate)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("payroll", "bank");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.addsAmount).HasColumnName("addsAmount");
            this.Property(t => t.endDate).HasColumnName("endDate");
            this.Property(t => t.extraWorkedHours).HasColumnName("extraWorkedHours");
            this.Property(t => t.startDate).HasColumnName("startDate");
            this.Property(t => t.workedHours).HasColumnName("workedHours");
            this.Property(t => t.employee_id).HasColumnName("employee_id");

            // Relationships
            this.HasOptional(t => t.employee)
                .WithMany(t => t.payrolls)
                .HasForeignKey(d => d.employee_id);

        }
    }
}
