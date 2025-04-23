using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_2132
{
    internal class Randevuİslemleri_LSP_2132
    {
        internal interface IRandevuİslem_2132
        {
            void RandevuOlustur(Randevu_2132 randevu);
            void RandevuIptalEt(int randevuId);
        }

        internal class RandevuServisi : IRandevuİslem_2132
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
            private List<IRandevuİslem_2132> islemler = new List<IRandevuİslem_2132>();

            public void RandevuOlustur(Randevu_2132 randevu)
            {
                // Randevu oluşturma işlemleri
                Console.WriteLine($"Randevu oluşturuldu: {randevu.RandevuId}, {randevu.Tarih}");

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
    }
}
