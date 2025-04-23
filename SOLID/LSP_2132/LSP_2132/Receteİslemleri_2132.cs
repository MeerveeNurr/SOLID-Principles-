using System;
using System.Collections.Generic;
using static LSP_2132.Receteİslemleri_LSP_2132;

namespace LSP_2132
{
    internal class ReceteIslemleri : IReceteİslem_2132
    {
        private List<IReceteİslem_2132> islemler = new List<IReceteİslem_2132>();

        public void ReceteOlustur(Recete_2132 recete)
        {
            // Recete oluşturma işlemleri
            Console.WriteLine($"Reçete oluşturuldu: Ilac Adı: {recete.IlacAdi}, Doktor Adı: {recete.DoktorAdi}");

            foreach (var islem in islemler)
            {
                islem.ReceteOlustur(recete);
            }
        }

        public void IslemEkle(IReceteİslem_2132 islem)
        {
            islemler.Add(islem);
        }
    }

    internal class YanEtkiliReceteServisi : IReceteİslem_2132
    {
        private List<Recete_2132> receteler = new List<Recete_2132>();

        public void ReceteOlustur(Recete_2132 recete)
        {
            if (recete.YanEtkiliMi)
            {
                receteler.Add(recete);
            }
            else
            {
                Console.WriteLine("Bu recete yan etkili değil.");
            }
        }
    }


}
