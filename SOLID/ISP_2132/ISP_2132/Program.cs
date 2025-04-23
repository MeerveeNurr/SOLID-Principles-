using System;
using static ISP_2132.İlacİslemleri_ISP_2132;
using static ISP_2132.Receteİslemleri_ISP_2132;

namespace ISP_2132
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hasta, ilaç, muayene, randevu ve reçete verilerini oluştur
            Hasta_2132 hasta = new Hasta_2132(2, "Ekin", "Doğan");
            İlac_2132 ilac = new İlac_2132(1, "Devit", "D Vitamini", 200);
            Muayene_2132 muayene = new Muayene_2132(3, 3, 3, DateTime.Now);
            Randevu_2132 randevu = new Randevu_2132 (1, DateTime.Now );
            Recete_2132 recete = new Recete_2132 { IlacAdi = "Parol", DoktorAdi = "Dr. Ahmet", Tarih = DateTime.Now };

            // İşlem sınıflarını oluştur
            List<Hasta_2132> hastalar = new List<Hasta_2132>();

            İlacİslemleri_ISP_2132.IlacEkleme ilacServisi = new İlacİslemleri_ISP_2132.IlacEkleme();
            Muayeneİslemleri_ISP_2132.MuayeneServisi muayeneServisi = new Muayeneİslemleri_ISP_2132.MuayeneServisi();
            Randevuİslemleri_ISP_2132.RandevuServisi randevuServisi = new Randevuİslemleri_ISP_2132.RandevuServisi();
            Receteİslemleri_ISP_2132.ReceteServisi receteServisi = new Receteİslemleri_ISP_2132.ReceteServisi();

            // İşlemleri gerçekleştir
            IlacEkleme ilacEkleme = new IlacEkleme();
            ilacEkleme.IlacEkle(ilac);
            int hastaId = 1; 
            muayeneServisi.MuayeneGoruntule(hastaId);
            randevuServisi.RandevuOlustur(randevu);
            receteServisi.ReceteOlustur(recete);

            // Hasta ekleme işlemi
            Hasta_2132 hasta1 = new Hasta_2132(1, "Mehmet", "Kara");
            HastaEklemeServisi hastaEklemeServisi = new HastaEklemeServisi();
            hastaEklemeServisi.HastaEkle(hastalar, hasta1);

            Console.WriteLine("Muayene görüntülendi: Hasta ID: " + hastaId);
            Console.WriteLine("Randevu oluşturuldu: " + randevu.RandevuId + ", " + randevu.Tarih);
            Console.WriteLine("Reçete oluşturuldu: İlaç Adı: " + recete.IlacAdi + ", Doktor Adı: " + recete.DoktorAdi + ", Tarih: " + recete.Tarih);
            Console.WriteLine("Hasta eklendi: " + hasta.Ad + " " + hasta.Soyad);
            Console.WriteLine("İşlemler başarıyla gerçekleştirildi.");

            //UYGUN OLMAYAN

            IHastaEklemeServisi eklemeServisi = new HastaEklemeServisi();
            IHastaCikarmaServisi cikarmaServisi = new HastaCikarmaServisi();

          
            Hastaİslemleri_2132 hastaIslemleri = new Hastaİslemleri_2132(eklemeServisi, cikarmaServisi);
 
            Hasta_2132 yeniHasta = new Hasta_2132(1, "Şule", "Öztürk");
            hastaIslemleri.HastaEkle(yeniHasta);
            hastaIslemleri.HastaCikar(hastaId);
            İlacİslemleri_2132.IlacServisi ilacServisi2 = new İlacİslemleri_2132.IlacServisi();

            İlac_2132 yeniIlac = new İlac_2132 (2 , "Raviran", "Covid", 500 );

            ilacServisi2.IlacEkle(yeniIlac);

            ilacServisi2.IlacSil(yeniIlac);
          
            Muayeneİslemleri_2132.MuayeneServisi muayeneServisi2 = new Muayeneİslemleri_2132.MuayeneServisi();

            Muayene_2132 yeniMuayene = new Muayene_2132(1, 1, 1, DateTime.Now);

            muayeneServisi2.MuayeneGoruntule(1);
            muayeneServisi2.MuayeneIptalEt(1);
            muayeneServisi2.MuayeneSevkEt(1, 2);

            Randevuİslemleri_2132 randevuServisi2 = new Randevuİslemleri_2132();

            Randevu_2132 yeniRandevu = new Randevu_2132(2, DateTime.Now);

            randevuServisi2.RandevuOlustur(yeniRandevu);

            randevuServisi2.RandevuIptalEt(2);
            IReceteIslemleri receteServisi2 = new Receteİslemleri_2132();
            receteServisi2.ReceteIslemleriYap();


            // Console.ReadLine();

        }
    }
}

