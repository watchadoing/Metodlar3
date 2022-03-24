using System;
using System.Collections.Generic;
using System.Text;
// içinde operasyonlar olacak!
namespace OOP1
{
    internal class ProductManager
    {
        
        //ne ekleyeceğimizi verdiğimiz parametre yani metodun içinden çağrılma yolunu tanımlıyoruz.

        
        //(string abc) gibi düşün string cinsinden abc ver demek yerine Product cinsinden product ver demek)
        public void Add(Product product)
        {
            //encapsulation: herşeyi bir yere kaydedip toplama yollama demek
            Console.WriteLine(product.ProductName + "eklendi");

        }// void ne işe yarar? işlem sonucunun ne olduğunu bilmeye ihtiyaç olmayan komutlarda kullanılır

    }
    public void Update(Product product) 
        {
            Console.WriteLine(product.ProductName + "güncellendi");
        }


        

}
