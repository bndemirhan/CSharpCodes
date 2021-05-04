using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //implementation : uygulama

    //interface: imza'nın (fonksiyonumuz,methodumuz, void)aynı olduğu ancak imza içeriğinin farklı olduğu durumlarda interface. ( örn; imza karesini al= içerikte rakamlar değişir.

    // Interface miras alındığında içindeki tüm imzalar kullanılmak zorunda.



    interface ILoggerService
    {
        void Log();
    }
}
