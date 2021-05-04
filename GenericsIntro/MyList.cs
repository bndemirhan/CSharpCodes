using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items; // item : eleman
        //constructor
        public MyList()
        {
            items = new T[0];
        }

        //Void : geri döndürmez sadece tanımlarken yazdırırken kullanılır.
        //Ama biz herhangi bir işlem vs yaptırıp bize geri dönmesi istiyorsak void değil direkt istediğimiz tipi(int,string vs) kullanmalıyız.
        public void Add(T item) 
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }

        public int length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}
