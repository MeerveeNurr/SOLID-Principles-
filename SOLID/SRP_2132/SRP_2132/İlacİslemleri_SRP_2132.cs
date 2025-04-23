using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_2132
{
    internal class İlacİslemleri_SRP_2132
    {
        private List<Ilac_2132> ilaclar = new List<Ilac_2132>();

        public void IlacEkle(Ilac_2132 ilac)
        {
            ilaclar.Add(ilac);
            Console.WriteLine("İlaç eklendi: " + ilac.Ad);
        }
    }
}
