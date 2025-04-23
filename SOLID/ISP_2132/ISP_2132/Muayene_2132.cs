using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_2132
{
    internal class Muayene_2132
    {
        public int MuayeneId { get; set; }
        public int HastaId { get; set; }
        public int KlinikId { get; set; }
        public DateTime Tarih { get; set; }

        public Muayene_2132(int muayeneId, int hastaId, int klinikId, DateTime tarih)
        {
            MuayeneId = muayeneId;
            HastaId = hastaId;
            KlinikId = klinikId;
            Tarih = tarih;
        }
    }
}
