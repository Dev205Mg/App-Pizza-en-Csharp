using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Project_Pizza_V1
{
    class PizzaPersonnalisee : Pizza
    {
        static int randPizzaPersonnalisee = 0;
        public int numeroPizzaPersonnalisee { get; private set; }

        public PizzaPersonnalisee() : base("Personnalisée", 5f, false, null)
        {
            ingredients = new List<string>();

            randPizzaPersonnalisee++;
            numeroPizzaPersonnalisee = randPizzaPersonnalisee;
            nom = nom + " " + numeroPizzaPersonnalisee;

            while (true)
            {
                Console.Write("Rentrez un ingrédient pour la pizza personnalisée N°" +numeroPizzaPersonnalisee + " (ENTRER pour terminer) : ");
                var ingredient = Console.ReadLine();
                
                if (string.IsNullOrWhiteSpace(ingredient))
                {
                    break;
                }

                if (!ingredients.Contains(ingredient))
                {
                    ingredients.Add(ingredient);
                    Console.WriteLine(string.Join(", ", ingredients));
                    
                }
                else
                {
                    Console.WriteLine("ERREUR ! cette ingredient est déja dans la liste");
                }
                Console.WriteLine();
            }

            prix = prix + ingredients.Count * 1.5f;
        }
    }
}
