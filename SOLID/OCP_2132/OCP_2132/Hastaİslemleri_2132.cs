using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_2132
{
    internal class Hastaİslemleri_2132
    {
            private List<Hasta_2132> hastalar = new List<Hasta_2132>();
            private List<IHastaİslem_2132> islemler = new List<IHastaİslem_2132>();

        public void HastaEkle(Hasta_2132 hasta)
        {
            foreach (var islem in islemler)
            {
                islem.HastaEkle(hastalar, hasta);
            }
            Console.WriteLine("Hasta eklendi: " +hasta.HastaId +" "+ hasta.Ad + " " + hasta.Soyad); // Hasta bilgilerini burada doğrudan yazdırıyoruz
        }


        public void HastaCikar(int hastaId)
            {
                // Sadece çıkarma işlemi yapan HastaCikarmaServisi sınıfını burada doğrudan kullanıyoruz.
                var cikarmaServisi = new HastaCikarmaServisi();
                cikarmaServisi.HastaCikar(hastalar, hastaId);
                Console.WriteLine("Hasta çıkarıldı.");
            }
        }

    }