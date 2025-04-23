using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_2132
{
    internal class Hasta_2132
    {
        public int HastaId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public Hasta_2132(int hastaId, string ad, string soyad)
        {
            HastaId = hastaId;
            Ad = ad;
            Soyad = soyad;
        }
    }
}
