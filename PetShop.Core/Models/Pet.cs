using System;

namespace PetShop.Core.Models
{
    public class Pet : IComparable
    {
        public int? Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public PetType PetType
        {
            get;
            set;
        }

        public DateTime Birthdate
        {
            get;
            set;
        }

        public DateTime SoldDate
        {
            get;
            set;
        }

        public string Color
        {
            get;
            set;
        }

        public double Price
        {
            get;
            set;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Color} {PetType} {Price} {Birthdate.Date.ToString("M/dd/yyyy")}";
        }

        public int CompareTo(object? obj)
        {
            return (int)Math.Round(Price);
        }
    }
}