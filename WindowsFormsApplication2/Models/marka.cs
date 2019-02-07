using System;
using System.Collections.Generic;

namespace WindowsFormsApplication2.Models
{
    public partial class marka
    {
        public marka()
        {
            this.urunlers = new List<urunler>();
        }

        public string marka_id { get; set; }
        public string marka_adı { get; set; }
        public string marka_tel { get; set; }
        public virtual ICollection<urunler> urunlers { get; set; }
    }
}
