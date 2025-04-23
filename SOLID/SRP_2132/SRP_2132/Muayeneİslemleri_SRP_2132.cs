using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_2132
{
    internal class Muayeneİslemleri_SRP_2132
    {
        private List<Muayene_2132> muayeneler = new List<Muayene_2132>();

        public void MuayeneGoruntule(int hastaId)
        {
            var muayenelerHasta = muayeneler.FindAll(m => m.HastaId == hastaId);
            foreach (var muayene in muayenelerHasta)
            {
                Console.WriteLine("Muayene tarihi: " + muayene.Tarih.ToString("dd/MM/yyyy"));
            }
        }

        public void MuayeneIptalEt(int muayeneId)
        {
            var muayene = muayeneler.Find(m => m.MuayeneId == muayeneId);
            if (muayene != null)
            {
                muayeneler.Remove(muayene);
                Console.WriteLine("Muayene iptal edildi: " + muayene.Tarih.ToString("dd/MM/yyyy"));
            }
            else
            {
                Console.WriteLine("Muayene bulunamadı.");
            }
        }

        public void MuayeneSevkEt(int muayeneId, int yeniKlinikId)
        {
            var muayene = muayeneler.Find(m => m.MuayeneId == muayeneId);
            if (muayene != null)
            {
                muayene.KlinikId = yeniKlinikId;
                Console.WriteLine("Muayene başka bir kliniğe sevk edildi.");
            }
            else
            {
                Console.WriteLine("Muayene bulunamadı.");
            }
        }
    }
}
