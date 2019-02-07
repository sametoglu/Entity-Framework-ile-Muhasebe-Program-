using System;
using System.Collections.Generic;

namespace WindowsFormsApplication2.Models
{
    public partial class kategori
    {
        public kategori()
        {
            this.urunlers = new List<urunler>();
        }

        public string kategori_ID { get; set; }
        public string ad { get; set; }
        public string acıklama { get; set; }
        public virtual ICollection<urunler> urunlers { get; set; }
    }
}
