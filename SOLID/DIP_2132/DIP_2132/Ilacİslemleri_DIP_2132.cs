using System;

namespace DIP_2132
{
    internal class Ilacİslemleri_DIP_2132
    {
        internal interface IİlacEkleme_2132
        {
            void IlacEkle(Ilac_2132 ilac);
        }

        internal interface IİlacSilme_2132
        {
            void IlacSil(Ilac_2132 ilac);
        }
        private readonly IİlacEkleme_2132 ilacEklemeServisi;
        private readonly IİlacSilme_2132 ilacSilmeServisi;

        public Ilacİslemleri_DIP_2132(IİlacEkleme_2132 ilacEklemeServisi, IİlacSilme_2132 ilacSilmeServisi)
        {
            this.ilacEklemeServisi = ilacEklemeServisi;
            this.ilacSilmeServisi = ilacSilmeServisi;
        }

        public void IlacEkle(Ilac_2132 ilac)
        {
            ilacEklemeServisi.IlacEkle(ilac);
        }

        public void IlacSil(Ilac_2132 ilac)
        {
            ilacSilmeServisi.IlacSil(ilac);
        }
        internal class IlacEkleme : Ilacİslemleri_DIP_2132.IİlacEkleme_2132
        {
            public void IlacEkle(Ilac_2132 ilac)
            {
                Console.WriteLine("İlaç eklendi: " + ilac.Ad);
            }
        }

        internal class IlacSilme : Ilacİslemleri_DIP_2132.IİlacSilme_2132
        {
            public void IlacSil(Ilac_2132 ilac)
            {
                Console.WriteLine("İlaç silindi: " + ilac.Ad);
            }
        }
    }
}
