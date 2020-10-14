using System.Collections.Generic;
using System;

namespace Prov1_Prog2
{
    public class Kund
    {

        public string name;

        private int money;// vi behöver veta vilka böker spelaren har råd med
        private List<book> ownedBooks = new List<book>();//kunden vill inte ha duplicerade böckern så vi måste veta vilka hen äger

        static Random generator = new Random();
        private int evaluationSkills;// Vi behöver veta hur bra kunden är på att evaluate:a ett item

        public Kund(string ChosenName){
            ownedBooks.Add(book.storeBooks[generator.Next(0, book.storeBooks.Count)]);//lägger till en random bok till kunden från the store
        }
        public int Evaluate(){
            return 1;
        }

        public void BuyBook(){

        }

        private bool IsOwning(book bookToCheck){

            if(ownedBooks.Contains(bookToCheck)){
                return true;
            }
            else{
                return false;
            }

            
        }

    }
}
