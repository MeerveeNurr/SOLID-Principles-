using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_2132
{
    internal class Ilacİslemleri_2132
    {
        public class IlacDeposu
        {
            private List<Ilac_2132> ilaclar;

            public IlacDeposu()
            {
                ilaclar = new List<Ilac_2132>();
            }

            public void IlacEkle(Ilac_2132 ilac)
            {
                ilaclar.Add(ilac);
                Console.WriteLine("İlaç eklendi: " + ilac.Ad);
            }

            public void IlacSil(Ilac_2132 ilac)
            {
                ilaclar.Remove(ilac);
                Console.WriteLine("İlaç silindi: " + ilac.Ad);
            }
        }
    }
}
