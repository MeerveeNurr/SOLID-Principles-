using System;
using System.Collections.Generic;

namespace OCP_2132
{
    internal class MuayeneIslemleri_OCP_2132
    {
        private List<IMuayeneIslem_2132> islemler = new List<IMuayeneIslem_2132>();

        public void MuayeneGoruntule(int hastaId)
        {
            foreach (var islem in islemler)
            {
                islem.MuayeneGoruntule(hastaId);
            }
        }

        public void MuayeneIptalEt(int muayeneId)
        {
            foreach (var islem in islemler)
            {
                islem.MuayeneIptalEt(muayeneId);
            }
        }

        public void MuayeneSevkEt(int muayeneId, int yeniKlinikId)
        {
            foreach (var islem in islemler)
            {
                islem.MuayeneSevkEt(muayeneId, yeniKlinikId);
            }
        }

        public void IslemEkle(IMuayeneIslem_2132 islem)
        {
            islemler.Add(islem);
        }
    }

    internal class MuayeneServisi : IMuayeneIslem_2132
    {
        private List<Muayene_2132> muayeneler = new List<Muayene_2132>();

        public void MuayeneGoruntule(int hastaId)
        {
            var muayenelerHasta = muayeneler.FindAll(m => m.HastaId == hastaId);
            foreach (var muayene in muayenelerHasta)
            {
                Console.WriteLine($"Muayene tarihi: {muayene.Tarih.ToString("dd/MM/yyyy")}");
            }
        }

        public void MuayeneIptalEt(int muayeneId)
        {
            var muayene = muayeneler.Find(m => m.MuayeneId == muayeneId);
            if (muayene != null)
            {
                muayeneler.Remove(muayene);
                Console.WriteLine($"Muayene iptal edildi: {muayene.Tarih.ToString("dd/MM/yyyy")}");
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
