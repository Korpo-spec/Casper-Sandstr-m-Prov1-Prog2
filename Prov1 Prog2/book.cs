using System;

namespace Prov1_Prog2
{
    public class book
    {

        public int price;
        private string name;
        private int rarity;
        private string category;
        private int actualvalue;
        private bool cursed;
        static Random generator = new Random();

        public book(){

        }

        public void PrintInfo(){

        }

        public int Evaluate(){

            return 1;
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
