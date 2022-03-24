using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    internal class Musteri
    {
        // class içinde 1- özellik 2- operasyon tutar
        //özellik tutlan yerde operasyon tutulmaz
        //operasyon tutulan yerde özellik tutulmaz


        public int Id { get; set; }
        public string MursteriNo { get; set; }
        // eğer bir veri üzerinde matematiksel işlem yapmıyorsak onları STRING yapmalıyız. çünkü diğer sistemlerle veri uyumluluğu daha doğru
        //tc no vergi no gibi
        //eğer bir nesnede bir değer çokta kullanılacakmış gibi durmuyorsa orada SOTULAMA HATASI yapılıyor demektir



    }
}
