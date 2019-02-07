using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WindowsFormsApplication2.Models.Mapping
{
    public class personelMap : EntityTypeConfiguration<personel>
    {
        public personelMap()
        {
            // Primary Key
            this.HasKey(t => t.per_id);

            // Properties
            this.Property(t => t.per_id)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.kullanıcı_ad)
                .HasMaxLength(15);

            this.Property(t => t.sifre)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("personel");
            this.Property(t => t.per_id).HasColumnName("per_id");
            this.Property(t => t.kullanıcı_ad).HasColumnName("kullanıcı_ad");
            this.Property(t => t.sifre).HasColumnName("sifre");
        }
    }
}
