using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_2132
{//DosyayaYaz metodu ile dosyaya yazma işlemleri sınıf içinde tanımlanmıştır.
 //Bu durum SRP'ye aykırıdır çünkü dosyaya yazma işlemi muayene işlemleriyle doğrudan ilgili değildir.
 //Bu nedenle, DosyayaYaz metodu ayrı bir sınıfa veya sınıflara taşınmalıdır.
    internal class Muayeneİslemleri_2132
    {
        private List<Muayene_2132> muayeneler = new List<Muayene_2132>();

        public void MuayeneOlustur(Hasta_2132 hasta, DateTime tarih)
        {
            muayeneler.Add(new Muayene_2132 { Hasta = hasta, Tarih = tarih });
            Console.WriteLine("Muayene oluşturuldu: " + hasta.Ad + " " + hasta.Soyad + " - " + tarih.ToString("dd/MM/yyyy"));
            DosyayaYaz(hasta, tarih);
        }

        public void MuayeneIptalEt(int muayeneId)
        {
            var muayene = muayeneler.Find(m => m.MuayeneId == muayeneId);
            if (muayene != null)
            {
                muayeneler.Remove(muayene);
                Console.WriteLine("Muayene iptal edildi: " + muayeneId);
                DosyayaYaz(muayene);
            }
            else
            {
                Console.WriteLine("Muayene bulunamadı.");
            }
        }

        public void MuayeneDetaylariniYazdir(int muayeneId)
        {
            var muayene = muayeneler.Find(m => m.MuayeneId == muayeneId);
            if (muayene != null)
            {
                Console.WriteLine("Muayene detayları yazdırıldı: " + muayeneId);
                DosyayaYaz(muayene);
            }
            else
            {
                Console.WriteLine("Muayene bulunamadı.");
            }
        }

        private void DosyayaYaz(Hasta_2132 hasta, DateTime tarih)
        {
            var dosyaYolu = @"C:\MuayeneBilgileri.txt";
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(dosyaYolu, true))
            {
                sw.WriteLine("Muayene oluşturuldu: " + hasta.Ad + " " + hasta.Soyad + " - " + tarih.ToString("dd/MM/yyyy"));
            }
        }

        private void DosyayaYaz(Muayene_2132 muayene)
        {
            var dosyaYolu = @"C:\MuayeneBilgileri.txt";
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(dosyaYolu, true))
            {
                sw.WriteLine("Muayene iptal edildi: " + muayene.MuayeneId);
            }
        }
    }

}
