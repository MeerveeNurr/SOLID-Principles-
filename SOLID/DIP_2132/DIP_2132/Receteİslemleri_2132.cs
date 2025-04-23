using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_2132
{
    //ReceteIslemleri sınıfı ReceteServisi sınıfına doğrudan bağımlı.
    //Yani, ReceteIslemleri sınıfı,
    //ReceteServisi sınıfının bir örneğini oluşturarak ve ona doğrudan erişerek çalışıyor. Bu, DIP prensibine aykırıdır 
    internal class Receteİslemleri_2132
    {
        private ReceteServisi receteServisi;

        public void ReceteIslemleri()
        {
            this.receteServisi = new ReceteServisi(); // Burada doğrudan ReceteServisi sınıfının örneği oluşturuluyor
        }

        private List<Recete_2132> receteler = new List<Recete_2132>();

        public void ReceteOlustur(Recete_2132 recete)
        {
            receteler.Add(recete);
        }
    }

    internal class ReceteServisi
    {
        public void ReceteOlustur(Recete_2132 recete)
        {
            Console.WriteLine($"Reçete oluşturuldu: Ilac Adı: {recete.IlacAdi}, Doktor Adı: {recete.DoktorAdi} ,  Hasta Adı: {recete.HastaAdi}, Tarih {recete.Tarih}");

        }
    }
}
