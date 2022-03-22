using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    internal class DortIslem
    {
        public void Topla(int sayi1, int sayi2) 
        {
        int toplam= sayi1 + sayi2; 
        Console.WriteLine("Toplama Islemi Sonucunuz: " + toplam);


        }
        public void Cikar(int sayi1, int sayi2)
        {
            int fark= sayi1 - sayi2;
            Console.WriteLine("Cikartma Islemi Sonucunuz:" + fark);

        }
        public void Bol(int sayi1, int sayi2)
            {
            int bolum= sayi1 / sayi2;
            Console.WriteLine("Bolum sonucunuz: " + bolum);
        }
        public void Carp(int sayi1, int sayi2) 
        {
        int carim = sayi1 * sayi2;  
            Console.WriteLine("Carpım sonucunuz: " + carim);
        }
        public void Yuzde(int sayi1, int sayi2) 
        {
        int yuzde= (((sayi2 - sayi1) / sayi1) * 100);
            Console.WriteLine("Yüzde Sonucunuz: " + yuzde);
        }
    }
}
