using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_2132
{
    class Program
    {
        static void Main(string[] args)
        {
            var hastaIslemleri = new Hastaİslemleri_OCP_2132();

            var hasta = new Hasta_2132(1, "Ahmet", "Yılmaz");
            hastaIslemleri.HastaEkle(hasta);
            Console.WriteLine($"Hasta eklendi: ID: {hasta.HastaId}, Ad: {hasta.Ad}, Soyad: {hasta.Soyad}");

            var receteIslemleri = new Receteİslemleri_OCP_2132();
            var randevuIslemleri = new Randevuİslemleri_OCP_2132();
            var muayeneIslemleri = new MuayeneIslemleri_OCP_2132();
            var ilacIslemleri = new IlacIslemleri_OCP_2132();

            var randevu = new Randevu_2132 { RandevuId = 1, Tarih = DateTime.Now };
            var recete = new Recete_2132 { IlacAdi = "Parol", DoktorAdi = "Dr. Hakan", HastaAdi = "Ahmet", Tarih = DateTime.Now };
            recete.IlacListesi.Add("Ilac1");
            recete.IlacListesi.Add("Ilac2");
            Console.WriteLine($"Reçete eklendi: Ad: {recete.IlacAdi}, Doktor: {recete.DoktorAdi}, HastaAd: {recete.HastaAdi}, Tarih: {recete.Tarih}");

            receteIslemleri.ReceteOlustur(recete);
            Console.WriteLine();

            randevuIslemleri.RandevuOlustur(randevu);
            Console.WriteLine();

            // Bir hasta çıkarmak için
            int cikarilacakHastaId = 1;
            hastaIslemleri.HastaCikar(cikarilacakHastaId);
            Console.WriteLine("Hasta çıkarıldı.");

            Ilacİslemleri_2132 ilacIslemleri2 = new Ilacİslemleri_2132();
            Ilac_2132 yeniIlac = new Ilac_2132(1, "Endol", "Romatizma", 15);
            ilacIslemleri2.IlacEkle(yeniIlac);
            Console.WriteLine("İlaç eklendi.");

            MuayeneIslemleri_2132 muayeneIslemleri2 = new MuayeneIslemleri_2132();
            muayeneIslemleri2.IslemEkle(new Muayene_2132(1, 1, DateTime.Now));
            muayeneIslemleri2.IslemEkle(new Muayene_2132(2, 2, DateTime.Now.AddDays(-2)));
            muayeneIslemleri2.MuayeneGoruntule(1);
            muayeneIslemleri2.MuayeneIptalEt(2);
            muayeneIslemleri2.MuayeneSevkEt(1, 2);
            Console.WriteLine("Muayene görüntülendi.");

        
        }
    }
}
