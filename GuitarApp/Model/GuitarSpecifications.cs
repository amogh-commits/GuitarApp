using System;

namespace GuitarApp.Model
{
    public enum Builder
    {
        Fender, Martin, Gibson, Collings, Olson, Ryan, PRS, Any
    }

    public enum TypeOfGuitar
    {
        Acoustic, Electric
    }

    public enum Wood
    {
        IndianRosewood, BrazilianRosewood, Mahogany, Maple, Cocobolo, Cedar, Adirondack, Alder, Sitka, Any
    }

    public class GuitarSpec
    {
        public Builder Builder { get; }
        public string Model { get; }
        public TypeOfGuitar Type { get; }
        public Wood BackWood { get; }
        public Wood TopWood { get; }

        public GuitarSpec(Builder builder, string model, TypeOfGuitar type, Wood backWood, Wood topWood)
        {
            Builder = builder;
            Model = model;
            Type = type;
            BackWood = backWood;
            TopWood = topWood;
        }

        public override string ToString()
        {
            return $"{Builder} {Model} {Type} guitar with {BackWood} back and sides, {TopWood} top.";
        }

        public bool Matches(GuitarSpec otherSpec)
        {
            if (Builder != otherSpec.Builder)
                return false;
            if ((Model != null) && (!Model.Equals("")) && (!Model.Equals(otherSpec.Model)))
                return false;
            if (Type != otherSpec.Type)
                return false;
            if (BackWood != otherSpec.BackWood)
                return false;
            if (TopWood != otherSpec.TopWood)
                return false;
            return true;
        }
    }
}
