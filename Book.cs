using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_rundläggande_modellering
{
    //Klassen utgör böcker i spelet. Dessa kan värdesättas av spelaren utifrån kundens intresse och dess egenskaper.
    class Book
    {
        private string name;
        private string category;
        public int price;
        private int rarity;
        private int actualValue;
        private bool cursed;

        //Skapar bok och genererar slumpmässiga värden för dess egenskaper
        public Book()
        {
            Random generator = new Random();
            List<string> names = new List<string>() { "A Book About Snails", "Seven Cats", "Shopping penguin"};
            List<string> categorys = new List<string>() { "Dark magic", "Rituals", "Mythical Creatures" };

            name = names[generator.Next(0, names.Count)];
            category = categorys[generator.Next(0, categorys.Count)];
            rarity = generator.Next(0, 10);
            actualValue = generator.Next(0, 1000);
        }

       // Metoden returnerar bokens rätta pris utifrån dess sällsynthet och riktiga pris
       // I spelet används metoden för att värdesätta boken
       public int Evaluate()
       {
            Random generator = new Random();
            int finalPrice = actualValue * rarity;
            finalPrice = finalPrice * generator.Next(50, 150);
            finalPrice = finalPrice / 100;

            return finalPrice;
       }

        //Metoden skriver ut infomation om boken som är vesäntlig för spelaren
        public void PrintInfo()
        {
            Console.WriteLine(name);
            Console.WriteLine(category);
            Console.WriteLine(rarity);
            Console.WriteLine(Evaluate());
        }

    }
}
