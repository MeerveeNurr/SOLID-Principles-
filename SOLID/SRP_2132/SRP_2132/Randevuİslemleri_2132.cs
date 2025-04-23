using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_2132
{ //Randevuİslemleri_2132 sınıfı, randevu işlemleriyle ilgilenirken aynı zamanda loglama işlemlerini de gerçekleştirmektedir.
  //Bu durum SRP'ye aykırıdır çünkü loglama işlemi randevu işlemleriyle doğrudan ilgili değildir.
  //Dolayısıyla, loglama işlemleri başka bir sınıfa (Logger sınıfı gibi) taşınmalı ve
  //Randevuİslemleri_2132 sınıfı sadece randevu işlemleriyle ilgilenmelidir.
    internal class Randevuİslemleri_2132
    {
        private List<Randevu_2132> randevular = new List<Randevu_2132>();
        private Logger logger = new Logger();

        public void RandevuOlustur(Hasta_2132 hasta, DateTime tarih)
        {
            randevular.Add(new Randevu_2132 { Hasta_2132 = hasta, Tarih = tarih });
            Console.WriteLine("Randevu oluşturuldu: " + hasta.Ad + " " + hasta.Soyad);
            logger.Log("Randevu oluşturuldu: " + hasta.Ad + " " + hasta.Soyad);
        }

        public void RandevuIptalEt(int randevuId)
        {
            var randevu = randevular.Find(r => r.RandevuId == randevuId);
            if (randevu != null)
            {
                randevular.Remove(randevu);
                Console.WriteLine("Randevu iptal edildi: " + randevuId);
                logger.Log("Randevu iptal edildi: " + randevuId);
            }
            else
            {
                Console.WriteLine("Randevu bulunamadı.");
            }
        }

        public void RandevuGoruntule(int randevuId)
        {
            var randevu = randevular.Find(r => r.RandevuId == randevuId);
            if (randevu != null)
            {
                Console.WriteLine("Randevu görüntülendi: " + randevuId);
                logger.Log("Randevu görüntülendi: " + randevuId);
            }
            else
            {
                Console.WriteLine("Randevu bulunamadı.");
            }
        }

        public void RandevuGuncelle(int randevuId, DateTime yeniTarih)
        {
            var randevu = randevular.Find(r => r.RandevuId == randevuId);
            if (randevu != null)
            {
                randevu.Tarih = yeniTarih;
                Console.WriteLine("Randevu güncellendi: " + randevuId);
                logger.Log("Randevu güncellendi: " + randevuId);
            }
            else
            {
                Console.WriteLine("Randevu bulunamadı.");
            }
        }

        public void RandevuDetaylariniYazdir(int randevuId)
        {
            var randevu = randevular.Find(r => r.RandevuId == randevuId);
            if (randevu != null)
            {
                Console.WriteLine("Randevu detayları yazdırıldı: " + randevuId);
                logger.Log("Randevu detayları yazdırıldı: " + randevuId);
            }
            else
            {
                Console.WriteLine("Randevu bulunamadı.");
            }
        }
    }

    internal class Logger2
    {
        public void Log(string message)
        {
            var dosyaYolu = @"C:\Log.txt";
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(dosyaYolu, true))
            {
                sw.WriteLine(message);
            }
        }
    }
}
