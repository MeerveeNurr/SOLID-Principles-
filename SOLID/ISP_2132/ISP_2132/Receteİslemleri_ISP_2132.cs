using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_2132
{
    internal class Receteİslemleri_ISP_2132
    { 
        internal interface IReceteOlusturma_2132
        {
            void ReceteOlustur(Recete_2132 recete);
        }

        internal interface IReceteİslem_2132 : IReceteOlusturma_2132
        {
        }

        internal class ReceteServisi : IReceteOlusturma_2132
        {
            private List<Recete_2132> receteler = new List<Recete_2132>();

            public void ReceteOlustur(Recete_2132 recete)
            {
                receteler.Add(recete);
            }
        }

        internal class ReceteIslemleri : IReceteİslem_2132
        {
            private List<IReceteOlusturma_2132> islemler = new List<IReceteOlusturma_2132>();

            public void ReceteOlustur(Recete_2132 recete)
            {
                // Recete oluşturma işlemleri
                Console.WriteLine($"Reçete oluşturuldu: Ilac Adı: {recete.IlacAdi}, Doktor Adı: {recete.DoktorAdi}");

                foreach (var islem in islemler)
                {
                    islem.ReceteOlustur(recete);
                }
            }

            public void IslemEkle(IReceteOlusturma_2132 islem)
            {
                islemler.Add(islem);
            }
        }
    }

}
