using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    internal class BasvuruManager
    {
        //public void BasvuruYap()
        //{
            //Basvuru bilgilerini değerlendirme
            //kredi hesaplama
            
            //KonutKrediManager konutKrediManager = new KonutKrediManager();  
            //konutKrediManager.Hesapla //dersek tüm basvurularsadece konutkredi üzerinden hesaplanır!

        //}
                                                        //method incejtion yaptık
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService) 
        {
            krediManager.Hesapla(); // dersek ne çağırırsan çaağır çalışır
            loggerService.Log();

        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) //müşteriye iki üç krediyi aynı anda hesaplayıp gösterme

        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();    //listedeki herbir kredinin hesabını yaptım

            }
        }
    }
}
