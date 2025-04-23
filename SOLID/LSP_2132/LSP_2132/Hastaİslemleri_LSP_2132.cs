using System;
using System.Collections.Generic;

namespace LSP_2132
{
    internal interface IHastaEklemeServisi
    {
        void HastaEkle(List<Hasta_2132> hastalar, Hasta_2132 hasta);
    }

    internal interface IHastaCikarmaServisi
    {
        void HastaCikar(List<Hasta_2132> hastalar, int hastaId);
    }

    internal class HastaEklemeServisi : IHastaEklemeServisi
    {
        public void HastaEkle(List<Hasta_2132> hastalar, Hasta_2132 hasta)
        {
            hastalar.Add(hasta);
            Console.WriteLine("Hasta eklendi: " + hasta.Ad + " " + hasta.Soyad);
        }
    }

    internal class HastaCikarmaServisi : IHastaCikarmaServisi
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

    internal class Hastaİslemleri_LSP_2132
    {
        private List<Hasta_2132> hastalar = new List<Hasta_2132>();
        private List<IHastaEklemeServisi> eklemeServisleri = new List<IHastaEklemeServisi>();
        private List<IHastaCikarmaServisi> cikarmaServisleri = new List<IHastaCikarmaServisi>();

        public void EklemeServisiEkle(IHastaEklemeServisi servis)
        {
            eklemeServisleri.Add(servis);
        }

        public void CikarmaServisiEkle(IHastaCikarmaServisi servis)
        {
            cikarmaServisleri.Add(servis);
        }
    }
}
