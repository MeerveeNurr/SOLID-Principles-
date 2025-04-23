using System;
using System.Collections.Generic;
using static LSP_2132.Randevuİslemleri_LSP_2132;

namespace LSP_2132
{ //RandevuIslemleri sınıfı, IRandevuİslem_2132 arayüzünü doğru uygulamak yerine,
  //RandevuServisi sınıfının doğrudan bir örneğini içermekte ve bu örneği kullanarak işlemleri gerçekleştirmektedir.
  //Bu durum, LSP'ye uygun olmaz.


    internal class Randevuİslemleri_2132 : IRandevuİslem_2132
    {
        private List<Randevu_2132> randevular = new List<Randevu_2132>();

        public void RandevuOlustur(Randevu_2132 randevu)
        {
            randevular.Add(randevu);
        }

        public void RandevuIptalEt(int randevuId)
        {
            var randevu = randevular.Find(r => r.RandevuId == randevuId);
            if (randevu != null)
            {
                randevular.Remove(randevu);
            }
            else
            {
                Console.WriteLine("Randevu bulunamadı.");
            }
        }
    }

    internal class RandevuIslemleri : IRandevuİslem_2132
    {
        private RandevuServisi servis = new RandevuServisi();

        public void RandevuOlustur(Randevu_2132 randevu)
        {
         
            Console.WriteLine($"Randevu oluşturuldu: {randevu.RandevuId}, {randevu.Tarih}");

            servis.RandevuOlustur(randevu);
        }

        public void RandevuIptalEt(int randevuId)
        {
            servis.RandevuIptalEt(randevuId);
        }
    }
}
