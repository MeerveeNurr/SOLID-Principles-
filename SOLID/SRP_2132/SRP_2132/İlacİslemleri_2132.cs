using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_2132
{
    internal class İlacİslemleri_2132
    {
        private string yeniAd;

        public void IlacEkle(string ilacAdi)
        {
            Console.WriteLine("İlaç eklendi: " + ilacAdi);
        }

        public void IlacGuncelle(string ilacAdi)
        {
            //Ilac_2132.Ad = yeniAd;
            Console.WriteLine("İlaç güncellendi: " + ilacAdi);
        }

        public void IlacSil(string ilacAdi)
        {
            Console.WriteLine("İlaç silindi: " + ilacAdi);
        }
    }
}
