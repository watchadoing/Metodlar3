using System;

namespace Metodlar3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adı = "Elma";
            urun1.Aciklama = "amasya elması";
            urun1.Fiyati = 15;

            Urun urun2 = new Urun();
            urun2.Adı = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır";

            Urun[] urunler = new Urun[] { urun1, urun2, };

            foreach (var urun in urunler)
            {

                Console.WriteLine(urun.Adı);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine("-------");

            }

            Console.WriteLine("-------metodlar-------");

            var sepetManager = new SepetManager();
            //sepetManager.Ekle(urun1);


            //sepetManager.("armut", "yesil", "12");


            Console.WriteLine("Hello World!");
        }
    }
}







