using System;
using System.Collections.Generic;

namespace OCP_2132
{
    internal class Receteİslemleri_OCP_2132
    {
        private List<IReceteİslem_2132> islemler = new List<IReceteİslem_2132>();

        public void ReceteOlustur(Recete_2132 recete)
        {
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
    internal class ReceteServisi : IReceteİslem_2132
    {
        private List<Recete_2132> receteler = new List<Recete_2132>();

        public void ReceteOlustur(Recete_2132 recete)
        {
            receteler.Add(recete);
            Console.WriteLine($"Reçete oluşturuldu: Ilac Adı: {recete.IlacAdi}, Doktor Adı: {recete.DoktorAdi}");
        }
    }
}
