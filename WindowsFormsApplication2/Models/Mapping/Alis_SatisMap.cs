using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WindowsFormsApplication2.Models.Mapping
{
    public class Alis_SatisMap : EntityTypeConfiguration<Alis_Satis>
    {
        public Alis_SatisMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.musteri_ıd)
                .HasMaxLength(15);

            this.Property(t => t.urun_ıd)
                .HasMaxLength(15);

            this.Property(t => t.fatura_tip)
                .HasMaxLength(15);

            this.Property(t => t.fatura_durumu)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("Alis_Satis");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.musteri_ıd).HasColumnName("musteri_ıd");
            this.Property(t => t.urun_ıd).HasColumnName("urun_ıd");
            this.Property(t => t.siparis_tarihi).HasColumnName("siparis_tarihi");
            this.Property(t => t.teslim_tarihi).HasColumnName("teslim_tarihi");
            this.Property(t => t.adet).HasColumnName("adet");
            this.Property(t => t.fatura_tip).HasColumnName("fatura_tip");
            this.Property(t => t.fatura_durumu).HasColumnName("fatura_durumu");
            this.Property(t => t.fiyat).HasColumnName("fiyat");

            // Relationships
            this.HasOptional(t => t.musteriler)
                .WithMany(t => t.Alis_Satis)
                .HasForeignKey(d => d.musteri_ıd);
            this.HasOptional(t => t.urunler)
                .WithMany(t => t.Alis_Satis)
                .HasForeignKey(d => d.urun_ıd);

        }
    }
}
