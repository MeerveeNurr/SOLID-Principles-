using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_2132
{
    internal class Randevu_2132
    {
        public int RandevuId { get; set; }
        public int HastaId { get; set; }
        public int DoktorId { get; set; }
        public DateTime Tarih { get; set; }
        public Hasta_2132 Hasta_2132 { get; internal set; }
    }
}
