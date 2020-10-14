using System;
using System.Collections.Generic;

namespace Prov1_Prog2
{
    public class book
    {
        public static List<book> storeBooks = new List<book>();
        public int price;
        private string name;
        private static string[] theNames = {"return of the sith", "Old boring books", "Snoopdogs baking show script"};
        private int rarity;
        private string category;

        private static string[] theCategories = {"cooking", "swordfighting", "old books book"};
        private int actualvalue;
        private bool cursed;
        static Random generator = new Random();

        public book(){
            
            rarity = generator.Next(1,6);

            actualvalue = generator.Next(10, 101);

            category = theCategories[generator.Next(0,theCategories.Length)];

            name = theNames[generator.Next(0, theNames.Length)];

            int isCursed = generator.Next(0,11);

            if(isCursed < 8){
                cursed = false;
            }
            else{
                cursed = true;
            }

        }

        public void PrintInfo(){
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Rarity: " + rarity);
            Console.WriteLine("Category: " + category);
            Console.WriteLine("Price: " + price);
        }

        public int Evaluate(){

            price = actualvalue * rarity;
            float returnValueFloat = price * generator.Next(5,15)/10f;
            return Convert.ToInt32( returnValueFloat);
        }

        public string GetCategory(){

            return category;
        }

        public string GetName(){
            return name;
        }

        public bool IsCursed(){
            return cursed;
        }

    }
}
