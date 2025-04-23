using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using static DIP_2132.Ilacİslemleri_DIP_2132;
using static DIP_2132.Muayeneİslemleri_DIP_2132;
using static DIP_2132.Receteİslemleri_DIP_2132;

namespace DIP_2132
{
    class Program
    {
        static void Main(string[] args)
        {
            IHastaEylemServisi eylemServisi = new HastaEylemServisi();
            Hastaİslemleri_DIP_2132 hastaIslemleri = new Hastaİslemleri_DIP_2132(eylemServisi);

            Hasta_2132 hasta1 = new Hasta_2132(1, "Ramazan", "Kaya");
            Hasta_2132 hasta2 = new Hasta_2132(2, "Ayşe", "Şimşek");

            hastaIslemleri.HastaEkle(hasta1);
            hastaIslemleri.HastaEkle(hasta2);

            hastaIslemleri.HastaCikar(1);
            IlacEkleme ilacEklemeServisi = new IlacEkleme();
            IlacSilme ilacSilmeServisi = new IlacSilme();

            Ilac_2132 ilac1 = new Ilac_2132(1, "Asprin", "Ağrı Kesici", 75);
            Ilac_2132 ilac2 = new Ilac_2132(1, "Supradyn", "Takviye Gıda", 600);

            Ilacİslemleri_DIP_2132 ilacIslemleri = new Ilacİslemleri_DIP_2132(ilacEklemeServisi, ilacSilmeServisi);

            ilacIslemleri.IlacEkle(ilac1);
            ilacIslemleri.IlacEkle(ilac2);

            ilacIslemleri.IlacSil(ilac1);
            /* IMuayeneIslem_2132 muayeneIslem = new Muayeneİslemleri_DIP_2132();
             MuayeneServisi muayeneServisi = new MuayeneServisi(muayeneIslem);

             // Örnek bir muayene görüntülemesi
             muayeneServisi.MuayeneGoruntule(1); */

            Randevuİslemleri_DIP_2132.IRandevuOlusturma_2132 randevuOlusturma = new Randevuİslemleri_DIP_2132.RandevuServisi();
            Randevuİslemleri_DIP_2132.IRandevuIptalEtme_2132 randevuIptalEtme = new Randevuİslemleri_DIP_2132.RandevuServisi();

            Randevuİslemleri_DIP_2132.RandevuIslemleri randevuIslemleri = new Randevuİslemleri_DIP_2132.RandevuIslemleri(randevuOlusturma, randevuIptalEtme);

            Randevu_2132 randevu = new Randevu_2132 { RandevuId = 1, Tarih = DateTime.Now };
            randevuIslemleri.RandevuOlustur(randevu);
            randevuIslemleri.RandevuIptalEt(1);

            Receteİslemleri_DIP_2132.IReceteOlusturma_2132 receteOlusturma = new Receteİslemleri_DIP_2132.ReceteServisi();
            Receteİslemleri_DIP_2132.ReceteIslemleri receteIslemleri = new Receteİslemleri_DIP_2132.ReceteIslemleri(receteOlusturma);

            Recete_2132 recete = new Recete_2132("Parol", "Dr. Ahmet", "Sefa Aslan", System.DateTime.Now);
            receteIslemleri.ReceteOlustur(recete);

            // UYGUN OLMAYAN
            Hastaİslemleri_2132 hastaIslemleri2 = new Hastaİslemleri_2132();
            Hasta_2132 yeniHasta = new Hasta_2132(4, "Bilal", "Yılmaz");
            hastaIslemleri2.HastaEkle(yeniHasta);
            hastaIslemleri2.HastaCikar(4);

           // Ilacİslemleri_2132 ilacIslemleri1 = new Ilacİslemleri_2132();
            var ilacEklemeServisi1 = new Ilacİslemleri_2132.IlacDeposu();
            Ilac_2132 ilac = new Ilac_2132 (5,"Aferin","Soğuk Algınlığı",75);
            ilacEklemeServisi1.IlacEkle(ilac);
            ilacEklemeServisi1.IlacSil(ilac);

            var muayeneServisi = new Muayeneİslemleri_2132.MuayeneServisi();

            muayeneServisi.MuayeneGoruntule(1);
            muayeneServisi.MuayeneIptalEt(2);
            muayeneServisi.MuayeneSevkEt(3, 4);
            var randevuIslemleri1 = new RandevuIslemleri();
            var tarih = new DateTime(2023, 1, 1, 14, 30, 0);
            var randevu1 = new Randevu_2132 { RandevuId = 1, Tarih = tarih };

            randevuIslemleri1.RandevuOlustur(randevu1);
            randevuIslemleri1.RandevuIptalEt(1);
            randevuIslemleri1.RandevuIptalEt(3);

            Receteİslemleri_2132 receteIslemleri1 = new Receteİslemleri_2132();
            Recete_2132 recete2 = new Recete_2132("İburamin", "Dr. Amine", "Şevval Aslan", System.DateTime.Now);
            receteIslemleri.ReceteOlustur(recete2);
        }

    }
    }