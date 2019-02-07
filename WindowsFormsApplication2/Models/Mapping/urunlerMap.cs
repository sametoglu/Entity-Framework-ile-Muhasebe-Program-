using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WindowsFormsApplication2.Models.Mapping
{
    public class urunlerMap : EntityTypeConfiguration<urunler>
    {
        public urunlerMap()
        {
            // Primary Key
            this.HasKey(t => t.urun_ıd);

            // Properties
            this.Property(t => t.urun_ıd)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.urun_ad)
                .HasMaxLength(15);

            this.Property(t => t.kategori_ID)
                .HasMaxLength(15);

            this.Property(t => t.marka_id)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("urunler");
            this.Property(t => t.urun_ıd).HasColumnName("urun_ıd");
            this.Property(t => t.urun_ad).HasColumnName("urun_ad");
            this.Property(t => t.kategori_ID).HasColumnName("kategori_ID");
            this.Property(t => t.stok).HasColumnName("stok");
            this.Property(t => t.alıs_fiyatı).HasColumnName("alıs_fiyatı");
            this.Property(t => t.satıs_fiyatı).HasColumnName("satıs_fiyatı");
            this.Property(t => t.marka_id).HasColumnName("marka_id");

            // Relationships
            this.HasOptional(t => t.kategori)
                .WithMany(t => t.urunlers)
                .HasForeignKey(d => d.kategori_ID);
            this.HasOptional(t => t.marka)
                .WithMany(t => t.urunlers)
                .HasForeignKey(d => d.marka_id);

        }
    }
}
