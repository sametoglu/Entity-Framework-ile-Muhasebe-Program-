using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WindowsFormsApplication2.Models.Mapping
{
    public class kategoriMap : EntityTypeConfiguration<kategori>
    {
        public kategoriMap()
        {
            // Primary Key
            this.HasKey(t => t.kategori_ID);

            // Properties
            this.Property(t => t.kategori_ID)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.ad)
                .HasMaxLength(10);

            this.Property(t => t.acıklama)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("kategori");
            this.Property(t => t.kategori_ID).HasColumnName("kategori_ID");
            this.Property(t => t.ad).HasColumnName("ad");
            this.Property(t => t.acıklama).HasColumnName("acıklama");
        }
    }
}
