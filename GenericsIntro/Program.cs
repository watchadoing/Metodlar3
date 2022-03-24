using System;

namespace GenericsIntro
{//c# ta list olmasaydı list nasıl yazılırdı çalışması
    internal class Program
    {
        static void Main(string[] args)
        {   //string MyList' i isimlerdir
            MyList <string> isimler = new MyList <string>();
            isimler.Add("engin");

        }
    }
}
