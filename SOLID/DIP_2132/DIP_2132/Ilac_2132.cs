using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_2132
{
    internal class Ilac_2132
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Tur { get; set; }
        public int Fiyat { get; set; }

        public Ilac_2132(int id, string ad, string tur, int fiyat)
        {
            Id = id;
            Ad = ad;
            Tur = tur;
            Fiyat = fiyat;
        }
    }
}
