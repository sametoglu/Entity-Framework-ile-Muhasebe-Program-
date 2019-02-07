using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WindowsFormsApplication2.Models.Mapping
{
    public class markaMap : EntityTypeConfiguration<marka>
    {
        public markaMap()
        {
            // Primary Key
            this.HasKey(t => t.marka_id);

            // Properties
            this.Property(t => t.marka_id)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.marka_adı)
                .HasMaxLength(15);

            this.Property(t => t.marka_tel)
                .HasMaxLength(11);

            // Table & Column Mappings
            this.ToTable("marka");
            this.Property(t => t.marka_id).HasColumnName("marka_id");
            this.Property(t => t.marka_adı).HasColumnName("marka_adı");
            this.Property(t => t.marka_tel).HasColumnName("marka_tel");
        }
    }
}
