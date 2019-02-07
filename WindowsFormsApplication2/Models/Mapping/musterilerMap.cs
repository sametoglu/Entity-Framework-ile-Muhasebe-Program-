using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WindowsFormsApplication2.Models.Mapping
{
    public class musterilerMap : EntityTypeConfiguration<musteriler>
    {
        public musterilerMap()
        {
            // Primary Key
            this.HasKey(t => t.musteri_ıd);

            // Properties
            this.Property(t => t.musteri_ıd)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.musteri_ad)
                .HasMaxLength(15);

            this.Property(t => t.musteri_soyad)
                .HasMaxLength(15);

            this.Property(t => t.Tel)
                .HasMaxLength(11);

            this.Property(t => t.Vergi_no)
                .HasMaxLength(15);

            this.Property(t => t.Vergi_dairesi)
                .HasMaxLength(15);

            this.Property(t => t.musteriadsoyad)
                .HasMaxLength(30);

            this.Property(t => t.Adres)
                .HasMaxLength(50);

            this.Property(t => t.musteri_tip)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("musteriler");
            this.Property(t => t.musteri_ıd).HasColumnName("musteri_ıd");
            this.Property(t => t.musteri_ad).HasColumnName("musteri_ad");
            this.Property(t => t.musteri_soyad).HasColumnName("musteri_soyad");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.Vergi_no).HasColumnName("Vergi_no");
            this.Property(t => t.Vergi_dairesi).HasColumnName("Vergi_dairesi");
            this.Property(t => t.musteriadsoyad).HasColumnName("musteriadsoyad");
            this.Property(t => t.Adres).HasColumnName("Adres");
            this.Property(t => t.musteri_tip).HasColumnName("musteri_tip");
        }
    }
}
