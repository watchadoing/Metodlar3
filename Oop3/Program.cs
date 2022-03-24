using System;
using System.Collections.Generic;

namespace Oop3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //  ihtiyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //  tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //  konutKrediManager.Hesapla();
            
            
            //ÖNEMLİ--> interfaceler de o interfaceyi interfere eden class ın referans numarasını tutar

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); // interface de İLK'e en base olanı yazdık. yukarıda taşıt ihtiyac diye başladık ama burada ortak olanla başladık
              //ihtiyacKrediManager.Hesapla();iptal ettik

            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();iptal ettik

            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();iptal ettik


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, databaseLoggerService);

             //buraya IKrediManager atamam ama ihtiyacKrediManager falan atabilirim.
            
            List<IKrediManager> krediler=new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
