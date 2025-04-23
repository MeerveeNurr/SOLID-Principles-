using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_2132
{
    internal class MuayeneIslemleri_2132
    {
        private List<Muayene_2132> muayeneler = new List<Muayene_2132>();

        public void MuayeneGoruntule(int hastaId)
        {
            // Muayene görüntüleme işlemleri
            Console.WriteLine($"Muayene görüntülendi: Hasta ID: {hastaId}");
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

        public void IslemEkle(Muayene_2132 muayene)
        {
            muayeneler.Add(muayene);
        }

        // Yeni bir muayene işlemi eklemek istendiğinde mevcut kod değiştirilmelidir.
        public void YeniIslemYap(int muayeneId, string yeniIslem)
        {
            var muayene = muayeneler.Find(m => m.MuayeneId == muayeneId);
            if (muayene != null)
            {
                muayene.YapilanIslemler.Add(yeniIslem);
                Console.WriteLine("Yeni işlem eklendi.");
            }
            else
            {
                Console.WriteLine("Muayene bulunamadı.");
            }
        }
    }
}
