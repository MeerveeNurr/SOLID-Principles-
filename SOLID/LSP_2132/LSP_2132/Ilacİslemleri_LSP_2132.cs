using System;
using System.Collections.Generic;

namespace LSP_2132
{
    internal interface Iİlacİslemi_2132
    {
        void IlacEkle(Ilac_2132 ilac);
    }

    internal class IlacEkleme : Iİlacİslemi_2132
    {
        public void IlacEkle(Ilac_2132 ilac)
        {
            Console.WriteLine("İlaç eklendi: " + ilac.Ad);
        }
    }

    internal class IlacIslemleri_LSP_2132 : Iİlacİslemi_2132
    {
        private List<Ilac_2132> ilaclar = new List<Ilac_2132>();

        public void IlacCikar(Ilac_2132 ilac)
        {
            Console.WriteLine("İlaç çıkarıldı: " + ilac.Ad);
        }

        public void IlacEkle(Ilac_2132 ilac)
        {
            ilaclar.Add(ilac);
            Console.WriteLine("İlaç eklendi: " + ilac.Ad);
        }
    }
}
