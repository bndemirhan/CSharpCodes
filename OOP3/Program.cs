using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {

        //uyarı! : basvuru manager adlı bir classın içinde newlerken konut kredisi dahi alıyor
        //olsak newlemeyi çocuk yani miras alan class üzerinden değil de base yani temel class üzerinden yapmalıyız. alt classa bağımlı kılmamalıyız, genel yapmalıyız.


        //interfaceleri birbirinin alternatifi olan ancak kod içerikleri farklı olan durumlarda kullanırız.



        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}

