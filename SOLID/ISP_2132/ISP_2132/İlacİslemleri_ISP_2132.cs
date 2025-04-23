using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_2132
{
    internal class İlacİslemleri_ISP_2132
    {
      
        internal interface IİlacEkleme_2132
        {
            void IlacEkle(İlac_2132 ilac);
        }

        internal interface IİlacSilme_2132
        {
            void IlacSil(İlac_2132 ilac);
        }

        internal class IlacEkleme : IİlacEkleme_2132
        {
            public void IlacEkle(İlac_2132 ilac)
            {
                Console.WriteLine("İlaç eklendi: " + ilac.Ad);
            }
        }

        internal class IlacSilme : IİlacSilme_2132
        {
            public void IlacSil(İlac_2132 ilac)
            {
                Console.WriteLine("İlaç silindi: " + ilac.Ad);
            }
        }
    }

}
