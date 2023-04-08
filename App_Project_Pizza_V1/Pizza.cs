using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Project_Pizza_V1
{
    class Pizza
    {
        public string nom { get; protected set; }
        public float prix { get; protected set; }
        public bool vegetarienne { get; private set; }
        public List<string> ingredients { get; protected set; }


        public Pizza(string nom, float prix, bool vegetarienne, List<string> ingredients)
        {
            this.nom = nom;
            this.prix = prix;
            this.vegetarienne = vegetarienne;
            this.ingredients = ingredients;
        }

        public void Afficher()
        {
            //var ingredientsAfficher = new List<string>();
            /*Console.Write(nom);
            if (vegetarienne)
            {
                Console.Write( " (V)");
            }
            Console.Write(" - "+ prix + " € \n");*/

            string badjeVegetarienne = vegetarienne ? " (V)" : ""; // ternaire en c#; a = condition ? si vrai : si faux

            string nomAfficher = FormatPremiereLettreMajuscules(nom);

            Console.WriteLine(nomAfficher + badjeVegetarienne + " - " + prix + "€");
            /*
            foreach(var ingredient in ingredients)
            {
                ingredientsAfficher.Add(FormatPremiereLettreMajuscules(ingredient));
            }*/

            var ingredientsAfficher = ingredients.Select(i => FormatPremiereLettreMajuscules(i)).ToList(); // même chose que foreach


            Console.WriteLine(string.Join(", ", ingredientsAfficher));
            Console.WriteLine();
            
        }

        private static string FormatPremiereLettreMajuscules(string mot)
        {
            if (string.IsNullOrEmpty(mot))
            {
                return mot;
            }
            string majuscule = mot.ToUpper();
            string miniscule = mot.ToLower();
            mot = majuscule[0] + miniscule.Substring(1);

            return mot;
        }
    }
}
