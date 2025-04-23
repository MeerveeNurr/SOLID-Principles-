using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_2132
{
    internal class Randevuİslemleri_2132
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

        public void IslemEkle(Randevu_2132 randevu)
        {
            randevular.Add(randevu);
        }
    }
}
