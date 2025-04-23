namespace ISP_2132
{
    internal class İlacİslemleri_2132
    {
        internal interface IİlacIslemleri_2132
        {
            void IlacEkle(İlac_2132 ilac);
            void IlacSil(İlac_2132 ilac);
            void IlacBilgisiGuncelle(İlac_2132 ilac);
        }

        internal class IlacServisi : IİlacIslemleri_2132
        {
            public void IlacEkle(İlac_2132 ilac)
            {
                Console.WriteLine("İlaç eklendi: " + ilac.Ad);
            }

            public void IlacSil(İlac_2132 ilac)
            {
                Console.WriteLine("İlaç silindi: " + ilac.Ad);
            }

            public void IlacBilgisiGuncelle(İlac_2132 ilac)
            {
                Console.WriteLine("İlaç bilgisi güncellendi: " + ilac.Ad);
            }
        }
    }
}
