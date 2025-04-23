using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LSP_2132.Muayeneİslemleri_LSP_2132;
namespace LSP_2132
{
    internal class Muayeneİslemleri_2132 : IMuayeneIslem_2132
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
            // Burada iptal işlemi gerçekleştirilmiyor ama arayüz gerektiriyor gibi yapıldı.
            Console.WriteLine("Hata: Muayene iptal edilemez.");
        }

        public void MuayeneSevkEt(int muayeneId, int yeniKlinikId)
        {
            // Burada sevk işlemi gerçekleştirilmiyor ama arayüz gerektiriyor gibi yapıldı.
            Console.WriteLine("Hata: Muayene sevk edilemez.");
        }

        public void IslemEkle(Muayene_2132 muayene)
        {
            muayeneler.Add(muayene);
            Console.WriteLine($"Muayene eklendi: {muayene.Tarih.ToString("dd/MM/yyyy")}");
        }
    }
}
