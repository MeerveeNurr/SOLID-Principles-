using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_2132
{
    internal class Hastaİslemleri_2132
    {
            private List<Hasta_2132> hastalar = new List<Hasta_2132>();
            private IHastaEklemeServisi eklemeServisi;
            private IHastaCikarmaServisi cikarmaServisi;

            public Hastaİslemleri_2132(IHastaEklemeServisi eklemeServisi, IHastaCikarmaServisi cikarmaServisi)
            {
                this.eklemeServisi = eklemeServisi;
                this.cikarmaServisi = cikarmaServisi;
            }

            public void HastaEklemeServisiEkle(IHastaEklemeServisi servis)
            {
                eklemeServisi = servis;
            }

            public void HastaCikarmaServisiEkle(IHastaCikarmaServisi servis)
            {
                cikarmaServisi = servis;
            }

            public void HastaEkle(Hasta_2132 hasta)
            {
                eklemeServisi.HastaEkle(hastalar, hasta);
            }

            public void HastaCikar(int hastaId)
            {
                cikarmaServisi.HastaCikar(hastalar, hastaId);
            }
        }

    }
