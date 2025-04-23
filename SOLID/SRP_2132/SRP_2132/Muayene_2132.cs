using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_2132
{
    internal class Muayene_2132
    {
        public int MuayeneId { get; set; }
        public int HastaId { get; set; }
        public int DoktorId { get; set; }
        public int KlinikId { get; set; }
        public DateTime Tarih { get; set; }
        public Hasta_2132 Hasta { get; internal set; }
    }
}
