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

        public book(){//körs när boken skapas och randomisar stats till den
            
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

        public void PrintInfo(){// printar stats till spelaren
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Rarity: " + rarity);
            Console.WriteLine("Category: " + category);
            Console.WriteLine("Price: " + price);
        }

        public int Evaluate(){//Gissar vad boken egentligen är värd

            price = actualvalue * rarity;
            float returnValueFloat = price * generator.Next(5,15)/10f;
            return Convert.ToInt32( returnValueFloat);
        }

        public string GetCategory(){//ger categorin

            return category;
        }

        public string GetName(){//ger namnet
            return name;
        }

        public bool IsCursed(){// ska ha en chans att man inte får rätt svar men han inte, printar iaf om boken är cursed eller inte
            return cursed;
        }

    }
}
