using System.Collections.Generic;
using System;

namespace Prov1_Prog2
{
    public class Kund//jag vet att det är på svenska helt plötsligt kom inte på hur jag stavar till det på eng och orkade inte kolla upp :))
    {

        public string name;//namnet på kunden

        private int money;// vi behöver veta vilka böker spelaren har råd med
        private List<book> ownedBooks = new List<book>();//kunden vill inte ha duplicerade böckern så vi måste veta vilka hen äger

        static Random generator = new Random();
        private int evaluationSkills;// Vi behöver veta hur bra kunden är på att evaluate:a ett item

        public Kund()
        {
            
            ownedBooks.Add(book.storeBooks[generator.Next(0, book.storeBooks.Count)]);//lägger till en random bok till kunden från the store
        }
        public int Evaluate(book bookToEvaluate)//Kollar vad man tror att boken egentligen är värd
        {
            float guessedPrice = bookToEvaluate.price * generator.Next(5,15)/10f;
            return Convert.ToInt32(guessedPrice);
        }

        public void BuyBook(book bookToBuy){
            if (Evaluate(bookToBuy)< money&& !IsOwning(bookToBuy))//kollar om man har råd med boken och om man äger boken redan
            {
                ownedBooks.Add(bookToBuy);
                book.storeBooks.Remove(bookToBuy);
            }
        }

        private bool IsOwning(book bookToCheck){

            if(ownedBooks.Contains(bookToCheck))//Kollar om man äger boken redan
            {
                return true;
            }
            else{
                return false;
            }

            
        }

    }
}
