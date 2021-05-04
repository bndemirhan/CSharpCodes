using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            double oran = 1.45;
            bool girisYapmisMi = true ;  // sadece true veya false döndürür bool.

            if(girisYapmisMi == true)
            {
                Console.WriteLine("kullanıcı butonu");
            }

            else
            {
                Console.WriteLine("giriş yap butonu");
            }
            

            Console.WriteLine(kategoriEtiketi);

            for (int i = 2; i < 7; i++)
            {
                if (i % 2 == 0) 
                
                    Console.WriteLine(i);
               
            }
        }
    }
}
