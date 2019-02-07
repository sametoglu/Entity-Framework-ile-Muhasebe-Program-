using System;
using System.Collections.Generic;

namespace WindowsFormsApplication2.Models
{
    public partial class fatura
    {
        public string fatura_ıd { get; set; }
        public Nullable<double> siparis_fiyatı { get; set; }
        public Nullable<System.DateTime> fatura_tarih { get; set; }
        public string musteri_ad { get; set; }
        public string musteri_soyad { get; set; }
        public string musteri_tel { get; set; }
        public string musteri_vergi_no { get; set; }
        public string musteri_vergi_dairesi { get; set; }
        public string fatura_tip { get; set; }
        public string musteri_ıd { get; set; }
        public virtual musteriler musteriler { get; set; }
    }
}
