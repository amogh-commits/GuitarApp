using System;
using System.Collections.Generic;
using System.Linq;

namespace GuitarApp.Model
{
    public class Inventory
    {
        private readonly List<Guitar> guitars;

        public Inventory()
        {
            guitars = new List<Guitar>();
        }

        public void AddGuitar(string serialNumber, double price, Builder builder, string model, TypeOfGuitar type, Wood backWood, Wood topWood)
        {
            GuitarSpec spec = new GuitarSpec(builder, model, type, backWood, topWood);
            Guitar guitar = new Guitar(serialNumber, price, spec);
            guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serialNumber)
        {
            return guitars.FirstOrDefault(guitar => guitar.SerialNumber.Equals(serialNumber));
        }

        public List<Guitar> Search(GuitarSpec searchSpec)
        {
            return guitars.Where(guitar => guitar.Spec.Matches(searchSpec)).ToList();
        }
    }
}
