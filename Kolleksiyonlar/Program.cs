using System;
using System.Collections.Generic;

namespace Kolleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "engin", "murat", "kerem", "halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);


            // arraylar oluşturulduğu sınırlar içinde kalır yani eleman sayısı oluştururken kaçsa o kadardır.
            //Console.WriteLine(isimler[4]);
            //dizileri ek kodlarla genişletemezsin, eski adresteki veriler kaybolur!
            //gerçek hayatta dizilerin elemanları veritabanından gelir bu yuzden mudehale edemeyiz.
            //bu yüzden koleksiyonlar kullanılır.
            List<string> isimler2 = new List<string> { "engin", "murat", "kerem", "halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("ilker");
            Console.WriteLine(isimler2[4]);


            //Console.WriteLine(isimler2[4]);
            //kolleksiyonlar arrayler gibi değerleri kaybetmemeyi sağlar

            //


        }
    }
}
