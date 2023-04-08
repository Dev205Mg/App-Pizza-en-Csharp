using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Project_Pizza_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var pizzas = new List<Pizza> {
                new Pizza("4 fromages", 11.5f, true, new List<string> { "mozzarella", "cantal", "fromage de chèvre", "gruyère"}),
                new Pizza("indienne", 10.5f, false, new List<string> { "curry", "mozzarella", "poulet", "poivron", "oignon", "coriandre"}),
                new Pizza("mexicaine", 13f, false, new List<string> { "boeuf", "mozzarella", "maïs", "tomates", "oignon", "coriandre"}),
                new Pizza("margherita", 8f, true, new List<string> { "sauce tomate", "mozzarella", "basilic"}),
                new Pizza("calzone", 12f, false, new List<string> { "tomate", "jambon", "persil", "oignons"}),
                new Pizza("complète", 9.5f, false, new List<string> { "jambon", "oeuf", "fromage"}),
                new PizzaPersonnalisee(),
                new PizzaPersonnalisee()
            };

            //pizzas = pizzas.OrderBy(p => p.prix).ToList();

            //Pizza pizzaPrixMin = pizzas[0];
            //Pizza pizzaPrixMax = pizzas[0];
            /*
             * afficher seulement les pizzas vegetarienne
            pizzas = pizzas.Where( p => p.vegetarienne).ToList();

            * afficher seulement les pizzas non vegetarienne
            pizzas = pizzas.Where( p => !p.vegetarienne).ToList();
            */
            //afficher les pizzas contient des tomates
            //pizzas = pizzas.Where(p => p.ingredients.Where(i => i.ToLower().Contains("tomate")).ToList().Count > 0).ToList();
            foreach ( var pizza in pizzas)
            {
                pizza.Afficher();
                //pizzaPrixMax = pizza.prix > pizzaPrixMax.prix ? pizza : pizzaPrixMax;
                //pizzaPrixMin = pizza.prix < pizzaPrixMin.prix ? pizza : pizzaPrixMin;
            }
            /*
            Console.WriteLine();
            Console.WriteLine("La pizza la moins chere est : ");
            pizzaPrixMin.Afficher();
            Console.WriteLine("La pizza la plus chere est : ");
            pizzaPrixMax.Afficher();*/

            Console.ReadKey();
        }
    }
}
