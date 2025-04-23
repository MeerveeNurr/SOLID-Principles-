using System;

namespace ISP_2132
{
    internal class Muayeneİslemleri_2132
    {
        internal interface IMuayeneIslem_2132
        {
            void MuayeneGoruntule(int hastaId);
            void MuayeneIptalEt(int muayeneId);
            void MuayeneSevkEt(int muayeneId, int yeniKlinikId);
            void FarkliIslemYap();
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

            public void FarkliIslemYap()
            {
                Console.WriteLine("Farklı bir işlem yapıldı.");
            }
        }
    }
}
