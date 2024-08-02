using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSystem
{
    public class Yorum
    {
        public string Yazan { get; set; }
        public string YorumMetni { get; set; }
        public int Puan { get; set; }

        public void BilgiGoster()
        {
            Console.WriteLine($"Yazan: {Yazan}, Yorum: {YorumMetni}, Puan: {Puan}/5");
        }
    }
}
