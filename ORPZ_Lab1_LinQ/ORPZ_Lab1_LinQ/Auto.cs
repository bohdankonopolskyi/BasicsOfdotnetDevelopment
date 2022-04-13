using System;
using System.Collections.Generic;
namespace ORPZ_Lab1_LinQ
{
    public class Auto
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public CarBodyType BodyType { get; set; }
        public CarBodyColor BodyColor { get; set; }
        public int ManufactureYear { get; set; }
        public string VIN { get; set; }
        public string PlateNumber { get; set; }
        public TechnicalCondition Condition { get; set; }
        public ICollection<string> Owners { get; set; }
        public ICollection<string> Permissons { get; set; }

        public Auto()
        {
            Owners = new List<string>();
            Permissons = new List<string>();
        }

        public override string ToString()
        {
            return string.Format($"Manufacturer = {Manufacturer}, Model = {Model}, Body Type = {BodyType.ToString()}\n" +
                $"Body color = {BodyColor.ToString()}, Year = {ManufactureYear}, Plate = {PlateNumber}, VIN code = {VIN},\n" +
                $"Techinacal Condition = {Condition}");
       }
    }
}
