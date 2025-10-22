using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{
    public List<Car> ParkingLot { get; set; } = new List<Car>();

    public class Carlot
    {
        public static int numberOfCars = 0;

        public Carlot()
        {
            numberOfCars++;
        }
    }
    public void CheckCars()
    {
        foreach (var vehicle in ParkingLot)
        {
            Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}.");
        }
        
        
    }
}