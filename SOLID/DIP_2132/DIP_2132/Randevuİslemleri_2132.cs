using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DIP_2132.Randevuİslemleri_DIP_2132;

namespace DIP_2132
{
    //Bu kodda, RandevuIslemleri sınıfı, RandevuServisi sınıfını doğrudan oluşturarak kullanıyor.
    //Bu durum DIP'e aykırıdır çünkü yüksek seviyeli bir sınıf olan RandevuIslemleri,
    //düşük seviyeli bir sınıf olan RandevuServisi ile doğrudan etkileşim kuruyor
    internal class Randevuİslemleri_2132
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

    internal class RandevuIslemleri
    {
        private RandevuServisi randevuServisi;

        public RandevuIslemleri()
        {
            randevuServisi = new RandevuServisi();
        }

        public void RandevuOlustur(Randevu_2132 randevu)
        {
            randevuServisi.RandevuOlustur(randevu);
        }

        public void RandevuIptalEt(int randevuId)
        {
            randevuServisi.RandevuIptalEt(randevuId);
        }
    }
}