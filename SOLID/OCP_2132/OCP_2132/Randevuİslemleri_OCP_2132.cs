using System;
using System.Collections.Generic;

namespace OCP_2132
{
    internal class Randevuİslemleri_OCP_2132
    {
        private List<IRandevuİslem_2132> islemler = new List<IRandevuİslem_2132>();

        public void RandevuOlustur(Randevu_2132 randevu)
        {
            foreach (var islem in islemler)
            {
                islem.RandevuOlustur(randevu);
            }
        }
        public void RandevuIptalEt(int randevuId)
        {
            foreach (var islem in islemler)
            {
                islem.RandevuIptalEt(randevuId);
            }
        }

        public void IslemEkle(IRandevuİslem_2132 islem)
        {
            islemler.Add(islem);
        }
    }
    internal class RandevuServisi : IRandevuİslem_2132
    {
        private List<Randevu_2132> randevular = new List<Randevu_2132>();

        public void RandevuOlustur(Randevu_2132 randevu)
        {
            randevular.Add(randevu);
            Console.WriteLine("Randevu oluşturuldu: " + randevu.Tarih.ToString("dd/MM/yyyy"));
        }

        public void RandevuIptalEt(int randevuId)
        {
            var randevu = randevular.Find(r => r.RandevuId == randevuId);
            if (randevu != null)
            {
                randevular.Remove(randevu);
                Console.WriteLine("Randevu iptal edildi: " + randevu.Tarih.ToString("dd/MM/yyyy"));
            }
            else
            {
                Console.WriteLine("Randevu bulunamadı.");
            }
        }
    }
}
