
using System;

namespace DIP_2132
{
    internal interface IHastaEylemServisi
    {
        void HastaEkle(List<Hasta_2132> hastalar, Hasta_2132 hasta);
        void HastaCikar(List<Hasta_2132> hastalar, int hastaId);
    }

    internal class HastaEylemServisi : IHastaEylemServisi
    {
        public void HastaEkle(List<Hasta_2132> hastalar, Hasta_2132 hasta)
        {
            hastalar.Add(hasta);
            Console.WriteLine("Hasta eklendi: " + hasta.Ad + " " + hasta.Soyad);
        }

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

    internal class Hastaİslemleri_DIP_2132
    {
        private List<Hasta_2132> hastalar = new List<Hasta_2132>();
        private IHastaEylemServisi eylemServisi;

        public Hastaİslemleri_DIP_2132(IHastaEylemServisi eylemServisi)
        {
            this.eylemServisi = eylemServisi;
        }

        public void HastaEylemServisiEkle(IHastaEylemServisi servis)
        {
            eylemServisi = servis;
        }

        public void HastaEkle(Hasta_2132 hasta)
        {
            eylemServisi.HastaEkle(hastalar, hasta);
        }

        public void HastaCikar(int hastaId)
        {
            eylemServisi.HastaCikar(hastalar, hastaId);
        }
    }
}
