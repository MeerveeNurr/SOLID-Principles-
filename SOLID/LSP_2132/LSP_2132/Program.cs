using System;
using static LSP_2132.Muayeneİslemleri_LSP_2132;
using static LSP_2132.Randevuİslemleri_LSP_2132;
using static LSP_2132.Receteİslemleri_LSP_2132;


namespace LSP_2132
{
    internal class Program
    {
        private static void Main()
        {
            // Hasta İşlemleri
            var hastaIslemleri = new Hastaİslemleri_LSP_2132();
            var hastaEklemeServisi = new HastaEklemeServisi();
            var hastaCikarmaServisi = new HastaCikarmaServisi();

            var hasta = new Hasta_2132(1, "Merve", "Aslan");

           // hastaIslemleri.HastaEkle(hasta);
            //hastaIslemleri.HastaCikar(hasta.HastaId);

            Console.WriteLine();

            // Muayene İşlemleri
            var muayeneIslemleri = new MuayeneIslemleri_LSP_2132();
            var muayeneServisi = new MuayeneServisi();
            var muayene = new Muayene_2132(1, 1, 1, DateTime.Now);

            muayeneIslemleri.IslemEkle(muayene);
            muayeneIslemleri.MuayeneGoruntule(1);
            muayeneIslemleri.MuayeneSevkEt(1, 2);
            muayeneIslemleri.MuayeneIptalEt(1);

            Console.WriteLine();

            // Randevu İşlemleri
            var RandevuIslemleri = new Randevuİslemleri_LSP_2132();
            var randevuServisi = new RandevuServisi();


          // RandevuIslemleri.IslemEkle(randevuServisi);

            var randevu = new Randevu_2132
            {
                RandevuId = 1,
                Tarih = DateTime.Now
            };

            //RandevuIslemleri.RandevuOlustur(randevu);
           // RandevuIslemleri.RandevuIptalEt(1);


            Console.WriteLine();

            // İlaç İşlemleri
            var ilacIslemleri = new IlacIslemleri_LSP_2132();
            var ilacEklemeServisi = new IlacEklemeServisi();

           // ilacIslemleri.IlacEkle(ilacEklemeServisi);

            var ilac = new Ilac_2132(1, "Parol", "Ağrı Kesici", 25);
            ilacIslemleri.IlacEkle(ilac);

            //REÇETE
            var receteIslemleri = new Receteİslemleri_LSP_2132.ReceteIslemleri();
            var receteServisi = new Receteİslemleri_LSP_2132.ReceteServisi();

            receteIslemleri.IslemEkle(receteServisi);

            var recete = new Recete_2132
            {
                IlacAdi = "Parol",
                DoktorAdi = "Dr. Ahmet"
            };

            receteIslemleri.ReceteOlustur(recete);
            //UYGUN OLMAYAN
            Hasta_2132 hasta1 = new Hasta_2132(1, "Ali", "Yılmaz");
            Hasta_2132 hasta2 = new Hasta_2132(2, "Ayşe", "Kaya");

            HastaEklemeServisi eklemeServisi = new HastaEklemeServisi();
            HastaCikarmaServisi cikarmaServisi = new HastaCikarmaServisi();

            Hastaİslemleri_2132 islemler = new Hastaİslemleri_2132();
            islemler.EklemeServisiEkle(eklemeServisi);
            islemler.CikarmaServisiEkle(cikarmaServisi);

            islemler.EklemeServisiKullan(hasta1);
            islemler.EklemeServisiKullan(hasta2);

            islemler.CikarmaServisiKullan(1);
            islemler.CikarmaServisiKullan(2);

            Console.WriteLine();

            Iİlacİslem_2132 ilacIslem = new IlacIslemleri_2132();
            Ilac_2132 ilac1 = new Ilac_2132(1, "Calpol", "Ateş Düşürücü", 180);
            ((IlacIslemleri_2132)ilacIslem).IlacEkle(ilac1);
            ilacIslem.IlacCikar(ilac1);
            Iİlacİslem_2132 ilacServis = new IlacEklemeServisi();
            ilacServis.IlacCikar(ilac1);

          
            var muayeneServisi2 = new Muayeneİslemleri_2132();
            var muayene2 = new Muayene_2132(1, 1, 1, DateTime.Now);
            muayeneServisi.MuayeneGoruntule(1);
            //ÇIKTI?

            Randevuİslemleri_2132 servis = new Randevuİslemleri_2132();
            Randevuİslemleri_2132 randevuIslemleri = new Randevuİslemleri_2132();

            //randevuIslemleri1.ServisEkle(servis);

            Randevu_2132 randevu1 = new Randevu_2132 { RandevuId = 1, Tarih = DateTime.Now };
            Randevu_2132 randevu2 = new Randevu_2132 { RandevuId = 2, Tarih = DateTime.Now };

            Randevu_2132 randevu3 = new Randevu_2132 { RandevuId = 1, Tarih = DateTime.Now };
            RandevuIslemleri randevuIslemleri1 = new RandevuIslemleri();
            randevuIslemleri1.RandevuOlustur(randevu);
            //uygun olmayan recete
            Recete_2132 recete1 = new Recete_2132 { IlacAdi = "Levitiron", DoktorAdi = "Aysel" };
            Recete_2132 recete2 = new Recete_2132 { IlacAdi = "Apranax", DoktorAdi = "Emin" };

            ReceteIslemleri receteIslemleri2 = new ReceteIslemleri();
            IReceteİslem_2132 yanEtkiliReceteServisi = new YanEtkiliReceteServisi();
           receteIslemleri.IslemEkle(yanEtkiliReceteServisi);

            receteIslemleri2.ReceteOlustur(recete1);
            receteIslemleri2.ReceteOlustur(recete2);
       
        }
    }
}
