using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Alfa.Entities.Models.Mapping
{
    public class OPE_EXCMap : EntityTypeConfiguration<OPE_EXC>
    {
        public OPE_EXCMap()
        {
            // Primary Key
            this.HasKey(t => t.WRKID);

            // Properties
            this.Property(t => t.WRKID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OPE_NAME)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OPE_EXC");
            this.Property(t => t.WRKID).HasColumnName("WRKID");
            this.Property(t => t.OPE_ID).HasColumnName("OPE_ID");
            this.Property(t => t.OPE_NAME).HasColumnName("OPE_NAME");

            // Relationships
            this.HasOptional(t => t.OPERATION)
                .WithMany(t => t.OPE_EXC)
                .HasForeignKey(d => d.OPE_ID);
            this.HasRequired(t => t.WRKORD)
                .WithOptional(t => t.OPE_EXC);

        }
    }
}
