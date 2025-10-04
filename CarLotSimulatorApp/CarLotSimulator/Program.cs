using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var carLotOne = new CarLot();
            
            var car1 = new Car();
            car1.Year = 1978;
            car1.Make = "Nissan";
            car1.Model = "Datsun";
            car1.IsDriveable = true;
            
            car1.MakeEngineNoise("Clanking");
            car1.MakeHonkNoise("Beep beep");
            
            carLotOne.ParkingLot.Add(car1);
            
            var car2 = new Car();
            car2.Year = 2025;
            car2.Make = "Toyota";
            car2.Model = "Highlander";
            car2.IsDriveable = false;
            
            car2.MakeEngineNoise("Grinding");
            car2.MakeHonkNoise("Honk honk");
            
            carLotOne.ParkingLot.Add(car2);
            
            var car3 = new Car()
            {
                Year = 1998,
                Make = "Toyota",
                Model = "Corolla",
                IsDriveable = true,
            };

            car3.MakeEngineNoise("Roaaawwwwwwrrr");
            car3.MakeHonkNoise("WAAAAMP");
            
            carLotOne.ParkingLot.Add(car3);
            
            carLotOne.CheckCars();




            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
