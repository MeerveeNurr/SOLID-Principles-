using System;

namespace ISP_2132
{ //ReceteYazdir metodu, IReceteIslemleri arayüzüne eklenmiş ancak Receteİslemleri_2132 sınıfı
  //bu metodu kullanmıyor veya implemente etmiyor olabilir.
  //Bu durum, ISP'ye uymayan bir örnektir
    public interface IReceteIslemleri
    {
        void ReceteIslemleriYap();
        void ReceteYazdir();
    }

    public class Receteİslemleri_2132 : IReceteIslemleri
    {
        public void ReceteIslemleriYap()
        {
            Console.WriteLine("Reçete işlemleri yapılıyor.");
        }

        public void ReceteYazdir()
        {
            Console.WriteLine("Reçete yazdırılıyor.");
        }
    }
}
