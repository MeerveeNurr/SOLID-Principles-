using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_2132
{
    internal class Hastaİslemleri_OCP_2132
    {
        private List<Hasta_2132> hastalar = new List<Hasta_2132>();
        private List<IHastaİslem_2132> islemler = new List<IHastaİslem_2132>();

        public void HastaEkle(Hasta_2132 hasta)
        {
            foreach (var islem in islemler)
            {
                islem.HastaEkle(hastalar, hasta);
            }
            Console.WriteLine("Hasta eklendi: " + hasta.Ad + " " + hasta.Soyad);
        }

        public void HastaCikar(int hastaId)
        {
            foreach (var islem in islemler)
            {
                islem.HastaCikar(hastalar, hastaId);
            }
            Console.WriteLine("Hasta çıkarıldı.");
        }

        public void IslemEkle(IHastaİslem_2132 islem)
        {
            islemler.Add(islem);
        }
    }

    internal class HastaEklemeServisi : IHastaİslem_2132
    {
        public void HastaEkle(List<Hasta_2132> hastalar, Hasta_2132 hasta)
        {
            hastalar.Add(hasta);
            Console.WriteLine("Hasta eklendi: " + hasta.Ad + " " + hasta.Soyad);
        }

        public void HastaCikar(List<Hasta_2132> hastalar, int hastaId)
        {
            // HastaEklemeServisi sınıfı sadece ekleme işlemi yapar, çıkarma işlemi yapmaz.
            // Bu yüzden bu metodda bir işlem yapmaya gerek yok.
        }
    }

    internal class HastaCikarmaServisi : IHastaİslem_2132
    {
        public void HastaEkle(List<Hasta_2132> hastalar, Hasta_2132 hasta)
        {
            // HastaCikarmaServisi sınıfı sadece çıkarma işlemi yapar, ekleme işlemi yapmaz.
            // Bu yüzden bu metodda bir işlem yapmaya gerek yok.
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
}
