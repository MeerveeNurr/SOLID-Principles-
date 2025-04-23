using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_2132
{
    internal class Receteİslemleri_DIP_2132
    {
            internal interface IReceteOlusturma_2132
            {
                void ReceteOlustur(Recete_2132 recete);
            }

            internal class ReceteServisi : IReceteOlusturma_2132
            {
                private List<Recete_2132> receteler = new List<Recete_2132>();

                public void ReceteOlustur(Recete_2132 recete)
                {
                    receteler.Add(recete);
                }
            }

            internal class ReceteIslemleri
            {
                private IReceteOlusturma_2132 receteOlusturma;

                public ReceteIslemleri(IReceteOlusturma_2132 receteOlusturma)
                {
                    this.receteOlusturma = receteOlusturma;
                }

                public void ReceteOlustur(Recete_2132 recete)
                {
               
                Console.WriteLine($"Reçete oluşturuldu: Ilac Adı: {recete.IlacAdi}, Doktor Adı: {recete.DoktorAdi} ,  Hasta Adı: {recete.HastaAdi}, Tarih {recete.Tarih}");
            }
            }
        }
    }
