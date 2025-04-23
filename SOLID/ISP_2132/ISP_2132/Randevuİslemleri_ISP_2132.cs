using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_2132
{
    internal class Randevuİslemleri_ISP_2132
    {
        internal interface IRandevuOlusturma_2132
        {
            void RandevuOlustur(Randevu_2132 randevu);
        }

        internal interface IRandevuIptalEtme_2132
        {
            void RandevuIptalEt(int randevuId);
        }

        internal interface IRandevuIslem_2132 : IRandevuOlusturma_2132, IRandevuIptalEtme_2132
        {
        }

        internal class RandevuServisi : IRandevuOlusturma_2132, IRandevuIptalEtme_2132
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

        internal class RandevuIslemleri : IRandevuIslem_2132
        {
            private List<IRandevuIslem_2132> islemler = new List<IRandevuIslem_2132>();

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

            public void IslemEkle(IRandevuIslem_2132 islem)
            {
                islemler.Add(islem);
            }
        }
    }

}
