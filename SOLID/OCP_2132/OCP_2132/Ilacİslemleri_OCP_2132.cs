using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_2132
{
 
        internal class IlacIslemleri_OCP_2132
        {
            private List<Iİlacİslem_2132> islemler = new List<Iİlacİslem_2132>();

        public void IlacEkle(Ilac_2132 ilac)
        {
            Console.WriteLine($"İlaç eklendi: ID: {ilac.Id}, Ad: {ilac.Ad}, Tür: {ilac.Tur}, Fiyat: {ilac.Fiyat}");
            foreach (var islem in islemler)
            {
                islem.IlacEkle(ilac);
            }
        }

        public void IslemEkle(Iİlacİslem_2132 islem)
            {
                islemler.Add(islem);
            }
        }


        internal class IlacEklemeServisi : Iİlacİslem_2132
    {
            public void IlacEkle(Ilac_2132 ilac)
            {
                Console.WriteLine("İlaç eklendi: " + ilac.Ad);
            }
        }
    }