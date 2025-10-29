using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    public class CarLot
    {
        public static int numberOfCars = 0; // Moved here from the nested class

        public List<Car> ParkingLot { get; set; } = new List<Car>();
        
        public void CheckCars()
        {
            foreach (var vehicle in ParkingLot)
            {
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}.");
            }
        }
    }
}