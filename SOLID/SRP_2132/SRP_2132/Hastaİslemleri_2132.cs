using System;
using System.Collections.Generic;
using System.IO;

namespace SRP_2132
{ //Bu, SRP'ye aykırıdır
  //çünkü sınıfın sorumluluklarından biri olan hastalarla ilgili işlemler ile
  //dosyaya yazma işlemi ayrı bir sorumluluğu temsil etmelidir.
  //Bunun yerine, dosyaya yazma işlemi için ayrı bir sınıf oluşturulmalı ve
  //bu işlemi gerçekleştiren sınıf Hastaİslemleri_2132 sınıfının dışında yer almalıdır.
    internal class Hastaİslemleri_2132
    {
        private List<Hasta_2132> hastalar = new List<Hasta_2132>();

        public void HastaEkle(Hasta_2132 hasta)
        {
            hastalar.Add(hasta);
            Console.WriteLine("Hasta eklendi: " + hasta.Ad + " " + hasta.Soyad);
        }

        public void HastaCikar(int hastaId)
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

        public void HastaBilgileriniDosyayaYaz()
        {
            var dosyaYolu = @"C:\HastaBilgileri.txt";
            using (StreamWriter sw = new StreamWriter(dosyaYolu))
            {
                foreach (var hasta in hastalar)
                {
                    sw.WriteLine("Hasta Adı: " + hasta.Ad + ", Soyadı: " + hasta.Soyad);
                }
            }
            Console.WriteLine("Hasta bilgileri dosyaya yazıldı.");
        }
    }
}
