using System;
using System.Collections.Generic;

namespace WindowsFormsApplication2.Models
{
    public partial class urunler
    {
        public urunler()
        {
            this.Alis_Satis = new List<Alis_Satis>();
        }

        public string urun_ıd { get; set; }
        public string urun_ad { get; set; }
        public string kategori_ID { get; set; }
        public Nullable<int> stok { get; set; }
        public Nullable<double> alıs_fiyatı { get; set; }
        public Nullable<double> satıs_fiyatı { get; set; }
        public string marka_id { get; set; }
        public virtual ICollection<Alis_Satis> Alis_Satis { get; set; }
        public virtual kategori kategori { get; set; }
        public virtual marka marka { get; set; }
    }
}
