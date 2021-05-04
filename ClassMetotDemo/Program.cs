using System;

namespace ClassMetotDemo // 3. Hafta-3. Ödev
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();  //nesene oluşturduk newleyerek.
            musteri1.musteriId = 123;
            musteri1.musteriAd = "Ali";
            musteri1.musteriSoyad = "Yılmaz";
            musteri1.musteriTel = 5314562533;
            musteri1.musteriMail = "ay@gmail.com";

            Console.WriteLine("müşteri1 mail = "+musteri1.musteriMail+"\n");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle();
            musteriManager.Sil();
            musteriManager.Guncelle();
        }

    
    }
}
