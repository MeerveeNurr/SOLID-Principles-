public class Ilac_2132
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public string Tur { get; set; }
    public int Fiyat { get; set; }

    public Ilac_2132(int id, string ad, string tur, int fiyat)
    {
        Id = id;
        Ad = ad;
        Tur = tur;
        Fiyat = fiyat;
    }
}
