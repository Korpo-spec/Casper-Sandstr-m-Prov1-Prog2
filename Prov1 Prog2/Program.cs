using System.Collections.Generic;
using System;

namespace Prov1_Prog2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for (int i = 0; i < 20; i++)
            {
                book.storeBooks.Add(new book());
            }

            List<Kund> peopleBuyingStuff = new List<Kund>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Välj ett namn för kunden!");
                peopleBuyingStuff.Add(new Kund(Console.ReadLine()));
                Console.WriteLine("Vilket fint namn");
            }

            Console.ReadLine();
        }
    }
}
