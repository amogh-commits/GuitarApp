using GuitarApp.Model;
using System;
using System.Collections.Generic;

namespace GuitarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            InitializeInventory(inventory);

            GuitarSpec whatErinLikes = new GuitarSpec(Builder.Fender, "Stratocaster", TypeOfGuitar.Electric, Wood.Alder, Wood.Alder);
            List<Guitar> matchingGuitars = inventory.Search(whatErinLikes);

            if (matchingGuitars.Any())
            {
                foreach (var guitar in matchingGuitars)
                {
                    Console.WriteLine("Erin, you might like this: \n" + guitar);
                }
            }
            else
            {
                Console.WriteLine("Sorry Erin, we have nothing for you.");
            }
        }

        private static void InitializeInventory(Inventory inventory)
        {
            inventory.AddGuitar("11277", 3999.95, Builder.Collings, "CJ", TypeOfGuitar.Acoustic, Wood.IndianRosewood, Wood.Sitka);
            inventory.AddGuitar("V95693", 1499.95, Builder.Fender, "Stratocaster", TypeOfGuitar.Electric, Wood.Alder, Wood.Alder);
            inventory.AddGuitar("70108276", 2295.95, Builder.Gibson, "Les Paul", TypeOfGuitar.Electric, Wood.Mahogany, Wood.Maple);
            inventory.AddGuitar("82765501", 1890.95, Builder.Martin, "D-28", TypeOfGuitar.Acoustic, Wood.BrazilianRosewood, Wood.Adirondack);
            inventory.AddGuitar("77023", 6275.95, Builder.Olson, "SJ", TypeOfGuitar.Acoustic, Wood.IndianRosewood, Wood.Cedar);
            inventory.AddGuitar("1092", 12995.95, Builder.Ryan, "Cathedral", TypeOfGuitar.Acoustic, Wood.Cocobolo, Wood.Cedar);
            inventory.AddGuitar("566-62", 8999.95, Builder.PRS, "Custom 24", TypeOfGuitar.Electric, Wood.Mahogany, Wood.Maple);
        }
    }
}
