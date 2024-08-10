using System;

namespace GuitarApp.Model
{
    public class Guitar
    {
        public string SerialNumber { get; }
        public double Price { get; set; }
        public GuitarSpec Spec { get; }

        public Guitar(string serialNumber, double price, GuitarSpec spec)
        {
            SerialNumber = serialNumber;
            Price = price;
            Spec = spec;
        }

        public override string ToString()
        {
            return $"{Spec} Price: Rs.{Price}";
        }
    }
}
