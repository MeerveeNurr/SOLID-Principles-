using System;
using System.Collections.Generic;

namespace ISP_2132
{ //IRandevuIslemleri arayüzüne eklenen RandevuBilgisiGoster metodu,
  //Randevuİslemleri_2132 sınıfı tarafından da implemente edilmiştir.
  //Ancak, bu durum IRandevuIslemleri arayüzüne bağımlılığı artırabilir ve ISP'ye uymaz
    internal interface IRandevuIslemleri
    {
        void RandevuOlustur(Randevu_2132 randevu);
        void RandevuGuncelle(Randevu_2132 randevu);
        void RandevuIptalEt(int randevuId);
        void RandevuBilgisiGoster(int randevuId);
    }

    internal class Randevuİslemleri_2132 : IRandevuIslemleri
    {
        private List<Randevu_2132> randevular = new List<Randevu_2132>();

        public void RandevuOlustur(Randevu_2132 randevu)
        {
            randevular.Add(randevu);
            Console.WriteLine($"Randevu oluşturuldu: {randevu.RandevuId}, {randevu.Tarih}");
        }

        public void RandevuGuncelle(Randevu_2132 randevu)
        {
            
            Console.WriteLine($"Randevu güncellendi: {randevu.RandevuId}, {randevu.Tarih}");
        }

        public void RandevuIptalEt(int randevuId)
        {
            var randevu = randevular.Find(r => r.RandevuId == randevuId);
            if (randevu != null)
            {
                randevular.Remove(randevu);
                Console.WriteLine($"Randevu iptal edildi: {randevu.RandevuId}, {randevu.Tarih}");
            }
            else
            {
                Console.WriteLine("Randevu bulunamadı.");
            }
        }

        public void RandevuBilgisiGoster(int randevuId)
        {
            var randevu = randevular.Find(r => r.RandevuId == randevuId);
            if (randevu != null)
            {
                Console.WriteLine($"Randevu bilgileri: {randevu.RandevuId}, {randevu.Tarih}");
            }
            else
            {
                Console.WriteLine("Randevu bulunamadı.");
            }
        }
    }
}
