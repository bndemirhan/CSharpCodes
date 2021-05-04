using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 123;
            urun1.Adi = "Elma";
            urun1.Fiyati = 5;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Id = 345;
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Id);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("----------METOTLAR----------");

           
            

            //instance = örnek

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle();  // sepet manager classında oluşturduğumuz metodları kullanıyoruz.
            sepetManager.Sil();

          
        }
    }
}
