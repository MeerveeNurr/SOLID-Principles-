using System;
using System.Collections.Generic;

namespace SRP_2132
{
    internal class Hastaİslemleri_SRP_2132
    {
        private List<Hasta_2132> hastalar = new List<Hasta_2132>();

        public void HastaEkle(Hasta_2132 hasta)
        {
            var hastaEklemeServisi = new HastaEklemeServisi();
            hastaEklemeServisi.HastaEkle(hastalar, hasta);
        }

        public void HastaCikar(int hastaId)
        {
            var hastaCikarmaServisi = new HastaCikarmaServisi();
            hastaCikarmaServisi.HastaCikar(hastalar, hastaId);
        }
        //nested class olarak tanımladım
        //Her sınıfın tek bir sorumluluğu var ve SRP'ye uygun bir yapı oldu
        private class HastaEklemeServisi
        {
            public void HastaEkle(List<Hasta_2132> hastalar, Hasta_2132 hasta)
            {
                hastalar.Add(hasta);
                Console.WriteLine("Hasta eklendi: " + hasta.Ad + " " + hasta.Soyad);
            }
        }

        private class HastaCikarmaServisi
        {
            public void HastaCikar(List<Hasta_2132> hastalar, int hastaId)
            {
                var hasta = hastalar.Find(h => h.HastaId == hastaId);
                if (hasta != null)
                {
                    hastalar.Remove(hasta);
                    Console.WriteLine("Hasta çıkarıldı: " + hasta.Ad + " " + hasta.Soyad);
                }
                else
                {
                    Console.WriteLine("Hasta bulunamadı.");
                }
            }
        }
    }
}
