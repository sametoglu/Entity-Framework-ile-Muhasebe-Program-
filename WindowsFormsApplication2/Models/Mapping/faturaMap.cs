using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WindowsFormsApplication2.Models.Mapping
{
    public class faturaMap : EntityTypeConfiguration<fatura>
    {
        public faturaMap()
        {
            // Primary Key
            this.HasKey(t => t.fatura_ıd);

            // Properties
            this.Property(t => t.fatura_ıd)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.musteri_ad)
                .HasMaxLength(15);

            this.Property(t => t.musteri_soyad)
                .HasMaxLength(15);

            this.Property(t => t.musteri_tel)
                .HasMaxLength(11);

            this.Property(t => t.musteri_vergi_no)
                .HasMaxLength(15);

            this.Property(t => t.musteri_vergi_dairesi)
                .HasMaxLength(15);

            this.Property(t => t.fatura_tip)
                .HasMaxLength(15);

            this.Property(t => t.musteri_ıd)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("fatura");
            this.Property(t => t.fatura_ıd).HasColumnName("fatura_ıd");
            this.Property(t => t.siparis_fiyatı).HasColumnName("siparis_fiyatı");
            this.Property(t => t.fatura_tarih).HasColumnName("fatura_tarih");
            this.Property(t => t.musteri_ad).HasColumnName("musteri_ad");
            this.Property(t => t.musteri_soyad).HasColumnName("musteri_soyad");
            this.Property(t => t.musteri_tel).HasColumnName("musteri_tel");
            this.Property(t => t.musteri_vergi_no).HasColumnName("musteri_vergi_no");
            this.Property(t => t.musteri_vergi_dairesi).HasColumnName("musteri_vergi_dairesi");
            this.Property(t => t.fatura_tip).HasColumnName("fatura_tip");
            this.Property(t => t.musteri_ıd).HasColumnName("musteri_ıd");

            // Relationships
            this.HasOptional(t => t.musteriler)
                .WithMany(t => t.faturas)
                .HasForeignKey(d => d.musteri_ıd);

        }
    }
}
