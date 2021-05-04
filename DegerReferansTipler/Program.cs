using System;

namespace DegerReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {

            //değer(value) tip : (değer eşitlemesi) int, decimal, float, boolean

           // referans tip : (adres eşitlemesi) arrays, class, interface...

           
            // DEĞER TİP:

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;

            Console.WriteLine(sayi1);

            // REFERANS TİP:

            int[] sayilar1 = new int[] { 10, 20, 30 };

            int[] sayilar2 = new int[] { 100, 200, 300 };

            sayilar1 = sayilar2;
            sayilar2[0] = 999;

            Console.WriteLine(sayilar1[0]);


        }
    }
}
