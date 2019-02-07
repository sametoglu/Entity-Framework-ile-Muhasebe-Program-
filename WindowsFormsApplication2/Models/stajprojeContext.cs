using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using WindowsFormsApplication2.Models.Mapping;

namespace WindowsFormsApplication2.Models
{
    public partial class stajprojeContext : DbContext
    {
        static stajprojeContext()
        {
            Database.SetInitializer<stajprojeContext>(null);
        }

        public stajprojeContext()
            : base("Name=stajprojeContext")
        {
        }

        public DbSet<Alis_Satis> Alis_Satis { get; set; }
        public DbSet<fatura> faturas { get; set; }
        public DbSet<kategori> kategoris { get; set; }
        public DbSet<marka> markas { get; set; }
        public DbSet<musteriler> musterilers { get; set; }
        public DbSet<personel> personels { get; set; }
        public DbSet<urunler> urunlers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Alis_SatisMap());
            modelBuilder.Configurations.Add(new faturaMap());
            modelBuilder.Configurations.Add(new kategoriMap());
            modelBuilder.Configurations.Add(new markaMap());
            modelBuilder.Configurations.Add(new musterilerMap());
            modelBuilder.Configurations.Add(new personelMap());
            modelBuilder.Configurations.Add(new urunlerMap());
        }
    }
}
