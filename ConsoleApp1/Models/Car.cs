using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class Car
    {
        public string LicensePlate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool IsAvailable { get; set; }
        public decimal PricePerDay { get; set; }
       
        public Car(string licensePlate, string brand, string model, int year, bool isAvailable, decimal pricePerDay)
        {
            LicensePlate = licensePlate;
            Brand = brand;
            Model = model;
            Year = year;
            IsAvailable = true;
            PricePerDay = pricePerDay;
        }
                public void DisplayInfo()
        {
            Console.WriteLine($"Az autó renszdszáma: {LicensePlate}, márkája: {Brand}, típusa: {Model}, gyártási éve {Year} " + (IsAvailable ? "kölcsönözhető" : "nem kölcsönözhető"));
        }

        public override string? ToString()
        {
            return $"Az autó renszdszáma: {LicensePlate}, márkája: {Brand}, típusa: {Model}, gyártási éve {Year} " + (IsAvailable ? "kölcsönözhető" : "nem kölcsönözhető");
        }
    }

}
