using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_2132
{ //Receteİslemleri_2132 sınıfı, reçete işlemleriyle ilgilenirken aynı zamanda loglama işlemlerini de gerçekleştirmektedir.
  //Bu durum SRP'ye aykırıdır çünkü loglama işlemi reçete işlemleriyle doğrudan ilgili değildir. 
    internal class Receteİslemleri_2132
    {
        private List<Recete_2132> receteler = new List<Recete_2132>();
        private Logger logger = new Logger();

        public void ReceteOlustur(Hasta_2132 hasta, string ilacAdi, string doz)
        {
            receteler.Add(new Recete_2132 { Hasta_2132 = hasta, IlacAdi = ilacAdi, Doz = doz });
            Console.WriteLine("Reçete oluşturuldu: " + hasta.Ad + " " + hasta.Soyad + " - " + ilacAdi + " - " + doz);
            logger.Log("Reçete oluşturuldu: " + hasta.Ad + " " + hasta.Soyad + " - " + ilacAdi + " - " + doz);
        }

        public void ReceteIptalEt(int receteId)
        {
            var recete = receteler.Find(r => r.ReceteId == receteId);
            if (recete != null)
            {
                receteler.Remove(recete);
                Console.WriteLine("Reçete iptal edildi: " + receteId);
                logger.Log("Reçete iptal edildi: " + receteId);
            }
            else
            {
                Console.WriteLine("Reçete bulunamadı.");
            }
        }

        public void ReceteDetaylariniYazdir(int receteId)
        {
            var recete = receteler.Find(r => r.ReceteId == receteId);
            if (recete != null)
            {
                Console.WriteLine("Reçete detayları yazdırıldı: " + receteId);
                logger.Log("Reçete detayları yazdırıldı: " + receteId);
            }
            else
            {
                Console.WriteLine("Reçete bulunamadı.");
            }
        }
    }
    internal class Logger
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
