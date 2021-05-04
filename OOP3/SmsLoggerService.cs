using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{

    // inheritancede imzanın içini doldururuz yani methodun ve her kalıtım yapılan yerde aynı şekilde kullanırız.
    //interface de ise methodun(imzanın) içi boş bırakılır ve aynı methodu her implemente ettiğimiz yerde kullanabiliriz.
    //ancak içeriğinde özgünüz.Aynı içerikte kullanmak zorunda değiliz. 
    //İnterface bu bakımdan çok kullanışlı ve i.f.nin içinde default olarak public tanımlıdır, methodun başına yazmaya gerek yok.

    class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms yollandı");
        }
    }
}
