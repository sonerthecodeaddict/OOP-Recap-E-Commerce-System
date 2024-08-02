using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSystem
{
    public class IndirimKodu
    {
        public string Kod { get; set; }
        public double IndirimOrani { get; set; }

        public double IndirimUygula(double toplamTutar)
        {
            return toplamTutar * IndirimOrani / 100;
        }
    }
}
