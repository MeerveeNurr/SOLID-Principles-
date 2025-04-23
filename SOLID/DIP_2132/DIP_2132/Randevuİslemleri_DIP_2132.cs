using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DIP_2132
{
    internal class Randevuİslemleri_DIP_2132
    {
        internal interface IRandevuOlusturma_2132
        {
            void RandevuOlustur(Randevu_2132 randevu);
        }

        internal interface IRandevuIptalEtme_2132
        {
            void RandevuIptalEt(int randevuId);
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

        internal class RandevuIslemleri
        {
            private IRandevuOlusturma_2132 randevuOlusturma;
            private IRandevuIptalEtme_2132 randevuIptalEtme;

            public RandevuIslemleri(IRandevuOlusturma_2132 randevuOlusturma, IRandevuIptalEtme_2132 randevuIptalEtme)
            {
                this.randevuOlusturma = randevuOlusturma;
                this.randevuIptalEtme = randevuIptalEtme;
            }

            public void RandevuOlustur(Randevu_2132 randevu)
            {
                this.randevuOlusturma.RandevuOlustur(randevu);
            }

            public void RandevuIptalEt(int randevuId)
            {
                this.randevuIptalEtme.RandevuIptalEt(randevuId);
            }
        }
    }
}

