using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_2132
{
    internal class Hastaİslemleri_2132
    {
        private List<Hasta_2132> hastalar = new List<Hasta_2132>();
        private List<IHastaEklemeServisi> eklemeServisleri = new List<IHastaEklemeServisi>();
        private List<IHastaCikarmaServisi> cikarmaServisleri = new List<IHastaCikarmaServisi>();

        public void EklemeServisiEkle(IHastaEklemeServisi servis)
        {
            eklemeServisleri.Add(servis);
        }

        public void CikarmaServisiEkle(IHastaCikarmaServisi servis)
        {
            cikarmaServisleri.Add(servis);
        }

        public void EklemeServisiKullan(Hasta_2132 hasta)
        {
            foreach (var servis in eklemeServisleri)
            {
                servis.HastaEkle(hastalar, hasta);
            }
        }

        public void CikarmaServisiKullan(int hastaId)
        {
            foreach (var servis in cikarmaServisleri)
            {
                servis.HastaCikar(hastalar, hastaId);
            }
        }

        public void HastaEkle(Hasta_2132 hasta)
        {
            hastalar.Add(hasta);
        }

        public void HastaCikar(int hastaId)
        {
            var hasta = hastalar.Find(h => h.HastaId == hastaId);
            if (hasta != null)
            {
                hastalar.Remove(hasta);
            }
        }
    }

}