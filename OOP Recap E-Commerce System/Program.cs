using System;
using System.Text;
using System.Collections.Generic;



namespace ECommerceSystem
{
	public class Program
	{
		public static void Main(string[] args)
		{

			Kitap kitap = new Kitap
			{
				Isim = "portakal sekeri",
				Yazar = "soner kocak",
				Fiyat = 10,
				Stok = 1000
			};

			Elektronik telefon = new Elektronik
			{
				Isim = "Redmi",
				Marka = "Xiaomi",
				Model = "Note 10 Pro",
				Fiyat = 1500,
				Stok = 200
			};

			Giyim tshirt = new Giyim
			{
				Isim = "T-Shirt",
				Beden = "XXL",
				Renk = "Siyah",
				Fiyat = 200,
				Stok = 50
			};

			Gida kiraz = new Gida
			{
				Isim = "Kiraz",
				Fiyat = 5,
				Stok = 1000
			};

			TemizlikMalzemesi domestos = new TemizlikMalzemesi
			{
				Isim = "Domestos",
				KullanimAlani = "Tualet, Banyo",
				Fiyat = 20,
				Stok = 155
			};

			TemizlikMalzemesi cif = new TemizlikMalzemesi
			{
				Isim = "Cif",
				KullanimAlani = "Mutfak",
				Fiyat = 10,
				Stok = 200
			};


			List<Urun> urunListesi = new List<Urun> { kitap, telefon, tshirt, kiraz };


			Yonetici yonetici = new Yonetici { Isim = "ahmet", Email = "cvbxcvbx@gmail.com" };
			Musteri musteri1 = new Musteri { Isim = "mehmet", Email = "cvbxcvbsbcvcb@gmail.com" };
			Musteri musteri2 = new Musteri { Isim = "ali", Email = "asdasdasdasd@gmail.com" };



			Console.WriteLine();
			yonetici.UrunEkle(kitap, urunListesi);
			yonetici.UrunEkle(telefon, urunListesi);
			yonetici.UrunEkle(tshirt, urunListesi);
			yonetici.UrunEkle(kiraz, urunListesi);
			yonetici.UrunEkle(domestos, urunListesi);
			yonetici.UrunEkle(cif, urunListesi);


			IndirimKodu indirim = new IndirimKodu { Kod = "indirim10", IndirimOrani = 10 };

			//siparis
			Siparis siparis1 = new Siparis { Musteri = musteri1 };
			siparis1.Indirim = indirim;
			siparis1.Urunler.Add(kitap);
			siparis1.Urunler.Add(telefon);
			siparis1.Urunler.Add(tshirt);
			siparis1.Urunler.Add(cif);
			siparis1.Urunler.Add(domestos);
			siparis1.ToplamTutarHesapla();
			musteri1.Siparisler.Add(siparis1);


			IOdemeYontemi odemeYontemi = new KrediKarti { KartNumarasi = "3131-5252-6969-1234", SonKullanmaTarihi = "12/26", CVV = "333" };

			Console.WriteLine();
			Console.WriteLine();
			siparis1.BilgiGoster();
			Console.WriteLine();
			odemeYontemi.OdemeYap(siparis1.ToplamTutar);



			//siparis 2
			Siparis siparis2 = new Siparis { Musteri = musteri2 };
			siparis2.Indirim = indirim;
			siparis2.Urunler.Add(kitap);
			siparis2.Urunler.Add(telefon);
			siparis2.Urunler.Add(tshirt);
			siparis2.Urunler.Add(cif);
			siparis2.Urunler.Add(cif);
			siparis2.Urunler.Add(domestos);
			siparis2.Urunler.Add(domestos);
			siparis2.Urunler.Add(domestos);
			siparis2.Urunler.Add(kiraz);
			siparis2.ToplamTutarHesapla();
			musteri2.Siparisler.Add(siparis2);


			IOdemeYontemi odemeYontemi2 = new KrediKarti { KartNumarasi = "1111-2222-3333-4444", SonKullanmaTarihi = "11/27", CVV = "111" };

			Console.WriteLine();
			Console.WriteLine();
			siparis2.BilgiGoster();
			Console.WriteLine();
			odemeYontemi2.OdemeYap(siparis2.ToplamTutar);



			//yorumlar
			Console.WriteLine();
			Console.WriteLine();
			Yorum yorum1 = new Yorum { Yazan = "ahmet", YorumMetni = "guzel kitap", Puan = 5 };
			kitap.YorumEkle(yorum1);
			Yorum yorum2 = new Yorum { Yazan = "ali", YorumMetni = "iyi telefon", Puan = 3 };
			telefon.YorumEkle(yorum2);

			Console.WriteLine();
			kitap.BilgiGoster();
			telefon.BilgiGoster();
		}
	}
}