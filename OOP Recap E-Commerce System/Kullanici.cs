using ECommerceSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSystem
{
    public abstract class Kullanici
    {
        public string Isim { get; set; }
        public string Email { get; set; }

        public abstract void BilgiGoster();
    }

    public class Musteri : Kullanici
    {
        public List<Siparis> Siparisler { get; set; } = new List<Siparis>();

        public override void BilgiGoster()
        {
            Console.WriteLine($"Müşteri: {Isim}, Email: {Email}");
            Console.WriteLine("Siparişler:");

            foreach (var siparis in Siparisler)
            {
                siparis.BilgiGoster();
            }
        }
    }


    public class Yonetici : Kullanici
    {
        public void UrunEkle(Urun urun, List<Urun> urunListesi)
        {
            urunListesi.Add(urun);
            Console.WriteLine($"{urun.Isim} ürün listesine eklendi.");
        }

        public override void BilgiGoster()
        {
            Console.WriteLine($"Yönetici: {Isim}, Email: {Email}");
        }
    }
}
