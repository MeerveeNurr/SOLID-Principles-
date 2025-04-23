using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_2132
{
    internal class Receteİslemleri_SRP_2132
    {
        private List<Recete_2132> receteler = new List<Recete_2132>();

        public void ReceteOlustur(Recete_2132 recete)
        {
            receteler.Add(recete);
            Console.WriteLine("Reçete oluşturuldu: " + recete.IlacAdi);
        }
    }
}
