using System;
using System.Collections.Generic;

namespace WindowsFormsApplication2.Models
{
    public partial class Alis_Satis
    {
        public string id { get; set; }
        public string musteri_ıd { get; set; }
        public string urun_ıd { get; set; }
        public Nullable<System.DateTime> siparis_tarihi { get; set; }
        public Nullable<System.DateTime> teslim_tarihi { get; set; }
        public Nullable<int> adet { get; set; }
        public string fatura_tip { get; set; }
        public string fatura_durumu { get; set; }
        public Nullable<double> fiyat { get; set; }
        public virtual musteriler musteriler { get; set; }
        public virtual urunler urunler { get; set; }
    }
}
