using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_2132
{
        internal interface IHastaEklemeServisi
        {
            void HastaEkle(List<Hasta_2132> hastalar, Hasta_2132 hasta);
        }

        internal interface IHastaCikarmaServisi
        {
            void HastaCikar(List<Hasta_2132> hastalar, int hastaId);
        }

        internal class HastaEklemeServisi : IHastaEklemeServisi
        {
            public void HastaEkle(List<Hasta_2132> hastalar, Hasta_2132 hasta)
            {
                hastalar.Add(hasta);
                Console.WriteLine("Hasta eklendi: " + hasta.Ad + " " + hasta.Soyad);
            }
        }

        internal class HastaCikarmaServisi : IHastaCikarmaServisi
        {
            public void HastaCikar(List<Hasta_2132> hastalar, int hastaId)
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

        internal class Hastaİslemleri_ISP_2132
        {
            private List<Hasta_2132> hastalar = new List<Hasta_2132>();
            private IHastaEklemeServisi eklemeServisi;
            private IHastaCikarmaServisi cikarmaServisi;

            public Hastaİslemleri_ISP_2132(IHastaEklemeServisi eklemeServisi, IHastaCikarmaServisi cikarmaServisi)
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

