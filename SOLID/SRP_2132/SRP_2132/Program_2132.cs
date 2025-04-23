using SRP_2132;

public class Program_2132
{
    public static void Main()
    {
        Hasta_2132 hasta = new Hasta_2132() { HastaId = 1, Ad = "Ali", Soyad = "Veli", DogumTarihi = new DateTime(1980, 1, 1) };
        Hastaİslemleri_SRP_2132 hastaIslemleri = new Hastaİslemleri_SRP_2132();
        hastaIslemleri.HastaEkle(hasta);

        Recete_2132 recete = new Recete_2132() { ReceteId = 1, HastaId = 1, IlacAdi = "Parol", Doz = "1 tablet" };
        Receteİslemleri_SRP_2132 receteIslemleri = new Receteİslemleri_SRP_2132();
        receteIslemleri.ReceteOlustur(recete);

        Ilac_2132 ilac = new Ilac_2132() { IlacId = 1, Ad = "Parol" };
        İlacİslemleri_SRP_2132 ilacIslemleri = new İlacİslemleri_SRP_2132();
        ilacIslemleri.IlacEkle(ilac);

        Randevu_2132 randevu = new Randevu_2132() { RandevuId = 1, HastaId = 1, Tarih = new DateTime(2024, 4, 5) };
        Randevuİslemleri_SRP_2132 randevuIslemleri = new Randevuİslemleri_SRP_2132();
        randevuIslemleri.RandevuOlustur(randevu);

        Muayene_2132 muayene = new Muayene_2132() { MuayeneId = 1, HastaId = 1, KlinikId = 1, Tarih = new DateTime(2024, 4, 5) };
        Muayeneİslemleri_SRP_2132 muayeneIslemleri = new Muayeneİslemleri_SRP_2132();
        muayeneIslemleri.MuayeneGoruntule(1);

        // SRP'ye uymayan sınıflar
        Hastaİslemleri_SRP_2132 hastaIslemleri_ = new Hastaİslemleri_SRP_2132();
        Hasta_2132 hasta_ = new Hasta_2132() { Ad = "Merve", Soyad = "Kara" };
        hastaIslemleri_.HastaEkle(hasta_);
        hastaIslemleri_.HastaCikar(1);

        Receteİslemleri_SRP_2132 receteIslemleri_ = new Receteİslemleri_SRP_2132();
        Recete_2132 recete_ = new Recete_2132() { HastaId = 1, IlacAdi = "Dexforte", Doz = "1 tablet" };
        receteIslemleri_.ReceteOlustur(recete_);

        İlacİslemleri_SRP_2132 ilacIslemleri_ = new İlacİslemleri_SRP_2132();
        Ilac_2132 ilac_ = new Ilac_2132() { Ad = "Dexforte" };
        ilacIslemleri_.IlacEkle(ilac_);

        Randevuİslemleri_SRP_2132 randevuIslemleri_ = new Randevuİslemleri_SRP_2132();
        Randevu_2132 randevu_ = new Randevu_2132() { HastaId = 1, Tarih = new DateTime(2024, 4, 5) };
        randevuIslemleri_.RandevuOlustur(randevu_);
        randevuIslemleri_.RandevuIptalEt(1);

        Muayeneİslemleri_SRP_2132 muayeneIslemleri_ = new Muayeneİslemleri_SRP_2132();
        Muayene_2132 muayene_ = new Muayene_2132() { HastaId = 1, KlinikId = 1, Tarih = new DateTime(2024, 4, 5) };
        muayeneIslemleri_.MuayeneGoruntule(1);
        muayeneIslemleri_.MuayeneIptalEt(1);
        muayeneIslemleri_.MuayeneSevkEt(1, 2);

        Console.ReadLine();
    }
}
