using System;
using System.Collections.Generic;

namespace WindowsFormsApplication2.Models
{
    public partial class musteriler
    {
        public musteriler()
        {
            this.Alis_Satis = new List<Alis_Satis>();
            this.faturas = new List<fatura>();
        }

        public string musteri_ıd { get; set; }
        public string musteri_ad { get; set; }
        public string musteri_soyad { get; set; }
        public string Tel { get; set; }
        public string Vergi_no { get; set; }
        public string Vergi_dairesi { get; set; }
        public string musteriadsoyad { get; set; }
        public string Adres { get; set; }
        public string musteri_tip { get; set; }
        public virtual ICollection<Alis_Satis> Alis_Satis { get; set; }
        public virtual ICollection<fatura> faturas { get; set; }
    }
}
