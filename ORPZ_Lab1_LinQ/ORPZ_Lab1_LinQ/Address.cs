using System;
namespace ORPZ_Lab1_LinQ
{
    public class Address
    {
        public string Region { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }

        public Address()
        {
        }

        public override string ToString()
        {
            return string.Format($"Region = {Region}, Street = {Street}, Number = {Number}. ");
        }
    }
}
