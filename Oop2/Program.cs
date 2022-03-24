using System;

namespace Oop2
{                               //OBJECT ORIENTED PROGRAMMING  nesne yönelimli programlama 
    internal class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi =  "Engin ";
            //musteri1.SoyAdi = "demirog";
            //musteri1.Id =  1";                                            //bunlara gerek kalmadı
            //musteri1.TcNo = "12345678910";
            //musteri1.MursteriNo = "12345";
            //musteri1.SirketAdi = "???"; // BEN BİR SİRKET DEĞİLİM BEN BİR SAHISIM!
            

            //ZAMANLA VERİLER YANLIŞ GİRİLİR TC NO SU OLAN ŞİRKET YAZILIR..
            // GERÇEK AYRI TÜZEL AYRI BİRBİRİ YERİNE KULLANILAMAZ
            //GERÇEK MÜŞTERİ
            //TÜZEL MÜŞTERİ
            //SOLID
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MursteriNo = "12345";
            musteri1.Adi = "engin";
            musteri1.SoyAdi = "demirog";
            musteri1.TcNo = "12345678910";
            musteri1.Id = 1;


            //tüzel müşteri girisi yapmaya çalışalım
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MursteriNo = "54321";
            musteri2.VergiNo = "13579";
            musteri2.SirketAdi = "asdfg";

            Musteri musteri3 = new GercekMusteri(); // new gördüğünde bellekte yeni referans numarası oluşturduğun aklına gelsin
            Musteri musteri4 = new TuzelMusteri();
           
            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(musteri1);
            customerManager.Ekle(musteri2);
            customerManager.Ekle(musteri3); 
            customerManager.Ekle(musteri4); 





            
            
        } 
    }
}
