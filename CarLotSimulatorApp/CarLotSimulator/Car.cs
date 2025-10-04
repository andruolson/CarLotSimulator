using System;

namespace CarLotSimulator;

public class Car
{
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDriveable { get; set; }

    public void MakeEngineNoise(string engineNoise)
    {
        EngineNoise = engineNoise;
            Console.WriteLine($"{Year} {Make} {Model} makes an engine noise that sounds like {EngineNoise}.");
    }

    public void MakeHonkNoise(string honkNoise)
    {
        HonkNoise = honkNoise;
            Console.WriteLine($"{Year} {Make} {Model} makes a honk noise that sounds like {HonkNoise}.");
            Console.WriteLine("----------------");
            Console.WriteLine($"Is the car driveable? {IsDriveable}");
            Console.WriteLine(" ");
    }
}





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