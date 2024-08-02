using ECommerceSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSystem
{
    // abstract
    public abstract class Urun
    {
        public string Isim { get; set; }
        public double Fiyat { get; set; }
        public int Stok { get; set; }
        public List<Yorum> Yorumlar { get; set; } = new List<Yorum>();

        public abstract void BilgiGoster();

        public void YorumEkle(Yorum yorum)
        {
            Yorumlar.Add(yorum);
            Console.WriteLine($"{Isim} için yorum eklendi");
        }
    }

    public class Kitap : Urun
    {
        public string Yazar { get; set; }

        public override void BilgiGoster()
        {
            Console.WriteLine($"Kitap: {Isim}, Yazar: {Yazar}, Fiyat: {Fiyat}, Stok: {Stok}");

            foreach (var yorum in Yorumlar)
            {
                yorum.BilgiGoster();
            }
        }
    }

    public class Elektronik : Urun
    {
        public string Marka { get; set; }
        public string Model { get; set; }

        public override void BilgiGoster()
        {
            Console.WriteLine($"Elektronik: {Isim}, Marka: {Marka}, Model: {Model}, Fiyat: {Fiyat}, Stok: {Stok}");

            foreach (var yorum in Yorumlar)
            {
                yorum.BilgiGoster();
            }
        }
    }

    public class Giyim : Urun
    {
        public string Beden { get; set; }
        public string Renk { get; set; }

        public override void BilgiGoster()
        {
            Console.WriteLine($"Giyim: {Isim}, Beden: {Beden}, Renk: {Renk}, Fiyat: {Fiyat}, Stok: {Stok}");

            foreach (var yorum in Yorumlar)
            {
                yorum.BilgiGoster();
            }
        }
    }

    public class Gida : Urun
    {
        public override void BilgiGoster()
        {
            Console.WriteLine($"Gıda: {Isim}, Fiyat: {Fiyat}, Stok: {Stok}");

            foreach (var yorum in Yorumlar)
            {
                yorum.BilgiGoster();
            }
        }
    }

    public class TemizlikMalzemesi : Urun
    {

        public string KullanimAlani { get; set; }

        public override void BilgiGoster()
        {
            Console.WriteLine($"Ürün: {Isim}, Kullanım Alanı: {KullanimAlani} Fiyat: {Fiyat}, Stok: {Stok}");

            foreach (var yorum in Yorumlar)
            {
                yorum.BilgiGoster();
            }
        }
    }
}
