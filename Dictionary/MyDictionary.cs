using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<K, V> //tipleri tanımladık
    {
        K[] keys;
        K[] tempKeys;
        V[] values;
        V[] tempValues;
        public MyDictionary() //classı her çağırdığımızda sıfır elemanlı bir array oluşturduk
        {
            keys = new K[0];
            values = new V[0];
        }
        public void Add(K key, V value) //K dizisine item parametresiyle eleman ekliyoruz
        {
            tempKeys = keys; //her yeni dizi oluşturulduğunda önceki elemanlar kaybolduğu için önceki elemanları tutan geçici bir dizi oluşturuyoruz
            tempValues = values;
            keys = new K[keys.Length + 1]; //her yeni K dizisi oluşturulduğunda +1 eleman diziye ekliyoruz
            values = new V[values.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++) //önceki dizide yer alan eleman sayısı kadar yeni dizinin eleman sayısını arttırıyoruz
            {
                keys[i] = tempKeys[i]; //gerçek dizi ile geçici dizinin eleman sayıları eşitlenene kadar for çalışıyor
            }
            keys[keys.Length - 1] = key; //çünkü dizilerin ilk elemanı sıfırdan başlar, bu yüzden eleman sayısından -1 azaltıp item isimli paremetreyi eşitliyoruz
            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }
            values[values.Length - 1] = value;
        }

        public int Count //bu da saydırmanın altyapısı, program.cs'ye count gelsin diye
        {
            get { return keys.Length; }
        }

        
        
        

    }
 }
