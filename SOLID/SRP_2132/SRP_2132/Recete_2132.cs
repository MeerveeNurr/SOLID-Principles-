using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_2132
{
    internal class Recete_2132
    {
        public int ReceteId { get; set; }
        public int HastaId { get; set; }
        public int DoktorId { get; set; }
        public string IlacAdi { get; set; }
        public string Doz { get; set; }
        public Hasta_2132 Hasta_2132 { get; internal set; }
    }
}
