using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    internal class MyList<T>
    {   //T programda verdiğimiz string yüzünden strin-tir
        T[] items;
        //constractor blogudur bir metoddur bir yerde new lersen mylist otomatik çalışır
        public MyList()
        {
            items = new T[0];   // 0 elamanlı array oluşturduk
        }
        public void Add(T item) 
        {
            T[] tempArray = items; //geçiçi dizi eski dizinin elemanlarını kaybetmemek için 
            items = new T[items.Length+1];
            for (int i = 0; 0 < tempArray.Length; i++)
            {   
                items[i] = tempArray[i]; //tempArray a atılan elemanları tekrar geri aldık

            }

            items[items.Length-] = item; //eklenmek istenen elemanı simdi ekledik



        }
    }
}
