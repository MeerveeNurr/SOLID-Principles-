using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_2132
{
    internal class Ilacİslemleri_2132
    {
        private List<Ilac_2132> ilaclar = new List<Ilac_2132>();

        public void IlacEkle(Ilac_2132 ilac)
        {
            // Sadece ekleme işlemi yapan IlacEklemeServisi sınıfını burada doğrudan kullanıyoruz.
            var eklemeServisi = new IlacEklemeServisi();
            eklemeServisi.IlacEkle(ilac);
            Console.WriteLine($"İlaç eklendi: ID: {ilac.Id}, Ad: {ilac.Ad}, Tür: {ilac.Tur}, Fiyat: {ilac.Fiyat}");
        }

        public void IslemEkle(Ilac_2132 ilac)
        {
            ilaclar.Add(ilac);
        }
    }
}
