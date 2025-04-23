using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_2132
{
    internal class Recete_2132
    {
        public string IlacAdi { get; set; }
        public string DoktorAdi { get; set; }
        public string HastaAdi { get; set; }
        public DateTime Tarih { get; set; }
        public List<string> IlacListesi { get; set; }
        public bool YanEtkiliMi { get; internal set; }

        public Recete_2132()
        {
            IlacListesi = new List<string>();
        }
    }
}
