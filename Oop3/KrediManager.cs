using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3      //operasyonları tanımlanacak
{
    internal interface IKrediManager //interface yaptık
                        //okunurluk için interfaceler I harfi ile başlar.
                        // kötü dilde interface yerine class kullanılır if kredi x ise şunu yap diye yazılır 
                        //ama 350 tane kredi var burası çok karışır!
    {
        void Hesapla();
        // bu imzanın aynı olduğu ama içerisinin farklı olduğu durumlarda class yerine interface kullanılır.
        void BiseyYap();

        //interface ler birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız

        
        
       
    }
}
