using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_2132
{ //IlacEklemeServisi sınıfı IlacIslemleri_2132 sınıfı ile yer değiştiremez veya
  //Iİlacİslem_2132 arayüzünü sağlayan herhangi bir sınıf ile yer değiştiremez.
  //Dolayısıyla, LSP'ye tam olarak uygun olmaz.

    internal interface Iİlacİslem_2132
    {
        void IlacEkle(Ilac_2132 ilac);
        void IlacCikar(Ilac_2132 ilac);
    }

    internal class IlacIslemleri_2132 : Iİlacİslem_2132
    {
        private List<Ilac_2132> ilaclar = new List<Ilac_2132>();

        public void IlacEkle(Ilac_2132 ilac)
        {
            ilaclar.Add(ilac);
                Console.WriteLine("İlaç eklendi: " + ilac.Ad);
            }

            public void IlacCikar(Ilac_2132 ilac)
            {
                ilaclar.Remove(ilac);
                Console.WriteLine("İlaç çıkarıldı: " + ilac.Ad);
            }
        }

        internal class IlacEklemeServisi : Iİlacİslem_2132
        {
            public void IlacEkle(Ilac_2132 ilac)
            {
                Console.WriteLine("İlaç eklendi: " + ilac.Ad);
            }

            public void IlacCikar(Ilac_2132 ilac)
            {
                // Burada ilaç çıkarılmıyor, ancak arayüz gerektiriyor gibi yapıldı.
                Console.WriteLine("Hata: İlaç çıkarılamaz.");
            }
        }

    }
