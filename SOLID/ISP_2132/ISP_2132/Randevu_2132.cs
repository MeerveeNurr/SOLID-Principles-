using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_2132
{
    internal class Randevu_2132
    {
        public int RandevuId { get; set; }
        public DateTime Tarih { get; set; }

        public Randevu_2132(int randevuId, DateTime tarih)
        {
            RandevuId = randevuId;
            Tarih = tarih;
        }
    }

}
