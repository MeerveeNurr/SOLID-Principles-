using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_2132
{
    //MuayeneServisi sınıfı, düşük seviyeli MuayeneIslemleri sınıfını doğrudan oluşturarak kullanıyor.
    //Bu durum DIP'ye aykırıdır çünkü yüksek seviyeli bir sınıf olan MuayeneServisi,
    //düşük seviyeli bir sınıf olan MuayeneIslemleri ile doğrudan etkileşim kuruyor.
    //DIP'ye göre, yüksek seviyeli sınıflar düşük seviyeli sınıflarla doğrudan etkileşim kurmamalı
    internal class Muayeneİslemleri_2132
    {
        public class MuayeneServisi
        {
            private readonly MuayeneIslemleri muayeneIslemleri;

            public MuayeneServisi()
            {
                muayeneIslemleri = new MuayeneIslemleri();
            }

            public void MuayeneGoruntule(int hastaId)
            {
                muayeneIslemleri.MuayeneGoruntule(hastaId);
            }

            public void MuayeneIptalEt(int muayeneId)
            {
                muayeneIslemleri.MuayeneIptalEt(muayeneId);
            }

            public void MuayeneSevkEt(int muayeneId, int yeniKlinikId)
            {
                muayeneIslemleri.MuayeneSevkEt(muayeneId, yeniKlinikId);
            }
        }

        public class MuayeneIslemleri
        {
            public void MuayeneGoruntule(int hastaId)
            {
                Console.WriteLine("Muayene görüntülendi: " + hastaId);
            }

            public void MuayeneIptalEt(int muayeneId)
            {
                Console.WriteLine("Muayene iptal edildi: " + muayeneId);
            }

            public void MuayeneSevkEt(int muayeneId, int yeniKlinikId)
            {
                Console.WriteLine("Muayene sevk edildi: " + muayeneId + " -> " + yeniKlinikId);
            }
        }

    }
}
