using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_2132
{
    internal class Muayene_2132
    {
        public int MuayeneId { get; set; }
        public int HastaId { get; set; }
        public int KlinikId { get; set; }
        public DateTime Tarih { get; set; }
        public List<string> YapilanIslemler { get; set; } // Yapılan işlemleri tutacak özellik
        public Muayene_2132(int muayeneId, int hastaId, DateTime tarih)
        {
            MuayeneId = muayeneId;
            HastaId = hastaId;
            Tarih = tarih;
            YapilanIslemler = new List<string>(); // Yapılan işlemler listesini başlat
        }
    }
}
