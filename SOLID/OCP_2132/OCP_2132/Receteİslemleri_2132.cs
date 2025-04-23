using System;
using System.Collections.Generic;

namespace OCP_2132
{
    internal class Receteİslemleri_2132
    {
        private List<Recete_2132> receteler = new List<Recete_2132>();

        public void ReceteOlustur(Recete_2132 recete)
        {
            receteler.Add(recete);
            Console.WriteLine($"Reçete oluşturuldu: Ilac Adı: {recete.IlacAdi}, Doktor Adı: {recete.DoktorAdi}");
        }

        public void IslemEkle(object islem)
        {
            if (islem is Recete_2132)
            {
                // Burada yeni bir işlem eklemek için ReceteOlustur metodunu değiştirmek gerekiyor.
                ReceteOlustur((Recete_2132)islem);
            }
            else
            {
                Console.WriteLine("Geçersiz işlem türü.");
            }
        }
    }
}
