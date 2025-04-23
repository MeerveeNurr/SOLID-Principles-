using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_2132
{
    // Bu durumda, yüksek seviyeli HastaIslemleri sınıfı,
    // düşük seviyeli List<Hasta> koleksiyonundan doğrudan etkilenmektedir. Bu, Dependency Inversion Principle'a aykırıdır,
    // çünkü yüksek seviyeli sınıfın düşük seviyeli detaylara bağımlı olmaması gerekmektedir.
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
    }
}
