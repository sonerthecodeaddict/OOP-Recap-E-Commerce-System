using ECommerceSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSystem
{
    public class Siparis
    {
        public List<Urun> Urunler { get; set; } = new List<Urun>();
        public Kullanici Musteri { get; set; }
        public double ToplamTutar { get; private set; }
        public string KargoDurumu { get; set; } = "Ödeme Bekleniyor";
        public string OdemeDurumu { get; set; } = "Bekleniyor";
        public string TakipNumarasi { get; set; }
        public IndirimKodu Indirim { get; set; }

        public void ToplamTutarHesapla()
        {
            ToplamTutar = 0;

            foreach (var urun in Urunler)
            {
                ToplamTutar += urun.Fiyat;
            }

            if (Indirim != null)
            {
                ToplamTutar -= Indirim.IndirimUygula(ToplamTutar);
            }
        }

        public void BilgiGoster()
        {
            Console.WriteLine($"Sipariş - Müşteri: {Musteri.Isim}, Toplam Tutar: {ToplamTutar}, Kargo Durumu: {KargoDurumu}, Ödeme Durumu: {OdemeDurumu}");

            foreach (var urun in Urunler)
            {
                urun.BilgiGoster();
            }

            if (Indirim != null)
            {
                Console.WriteLine($"Uygulanan İndirim Kodu: {Indirim.Kod}, İndirim Tutarı: {Indirim.IndirimUygula(ToplamTutar)}");
            }
        }
    }
}
