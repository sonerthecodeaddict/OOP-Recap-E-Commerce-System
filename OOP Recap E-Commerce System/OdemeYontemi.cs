using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSystem
{
    public interface IOdemeYontemi
    {
        void OdemeYap(double tutar);
    }

    public class KrediKarti : IOdemeYontemi
    {
        public string KartNumarasi { get; set; }
        public string SonKullanmaTarihi { get; set; }
        public string CVV { get; set; }

        public void OdemeYap(double tutar)
        {
            Console.WriteLine($"{tutar} tutarında ödeme kredi kartı ile yapıldı.");
        }
    }

    public class BankaTransferi : IOdemeYontemi
    {
        public string BankaAdi { get; set; }
        public string IBAN { get; set; }

        public void OdemeYap(double tutar)
        {
            Console.WriteLine($"{tutar} tutarında ödeme banka transferi ile yapıldı.");
        }
    }

    public class Iyzico : IOdemeYontemi
    {
        public string IyzicolHesabi { get; set; }

        public void OdemeYap(double tutar)
        {
            Console.WriteLine($"{tutar} tutarında ödeme Iyzico ile yapıldı.");
        }
    }
}
