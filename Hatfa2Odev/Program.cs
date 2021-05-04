using System;

namespace Hatfa2Odev
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.id = 1234;
            product1.name = "kalem";
            product1.colour = "yeşil";
            product1.price = 17.50;


            Product product2 = new Product();
            product2.id = 1235;
            product2.name = "defter";
            product2.colour = "kırmızı";
            product2.price = 25.00;


            Product product3 = new Product();
            product3.id = 1236;
            product3.name = "silgi";
            product3.colour = "mavi";
            product3.price = 4.25;


            Product[] products = new Product[] { product1, product2, product3 };

            //with for

            Console.WriteLine("\nFor ile: \n");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine((i+1)+".) "+"ürün id'si = " + products[i].id +"    "+
                    "ürün adı = " + products[i].name + "    " +
                    "ürün rengi = " + products[i].colour + "    " +
                    "ürün fiyatı = " + products[i].price+"    "+ "\n" );
            }

            Console.WriteLine("\n"+ "*************************************************************************************" + "\n");

            //with foreach
            Console.WriteLine("\nForeach ile: \n");
            

            foreach (var product in products)
            {
                Console.WriteLine("ürün id'si = " + product.id + "   " +
                    "ürün adı = " + product.name + "   " +
                    "ürün rengi = " + product.colour + "   " +
                    "ürün fiyatı = " + product.price + "\n");
            }

            
            Console.WriteLine("\n" + "*************************************************************************************" + "\n");

            //with while
            Console.WriteLine("\nWhile ile: \n");

            int j = 0;
            while (j < products.Length)
            {
                Console.WriteLine((j + 1) + ".) "+"ürün id'si = " + products[j].id + "    " +
               "ürün adı = " + products[j].name + "    " +
               "ürün rengi = " + products[j].colour + "    " +
               "ürün fiyatı = " + products[j].price + "    " + "\n");
                j++;

            }
        }
    class Product
        {
            public int id { get; set; }
            public string name { get; set; }
            public string colour { get; set; }
            public double price { get; set; }
        }
        }
    }
