using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLot = new CarLot();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var Car1 = new Car();
            Car1.Year = 2020;
            Car1.Make = "Ford";
            Car1.Model = "F-150";
            Car1.EngineNoise = "Vroom Vroom";
            Car1.HonkNoise = "Honk";
            Car1.IsDrivable = true;

            carLot.ParkingLot.Add(Car1);


            var Car2 = new Car()
            {
                Year = 1967,
                Make = "Ford",
                Model = "Shelby",
                EngineNoise = "Roooooom",
                HonkNoise = "beep",
                IsDrivable = true
            };

            carLot.ParkingLot.Add(Car2);



            var car3 = new Car(1923, "Ford", "Model T", " vroom", "beep", false);
            carLot.ParkingLot.Add(car3);
            
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach(var car in carLot.ParkingLot)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
                car.MakeEngineNoise();
                car.MakeHonkNoise();
                Console.WriteLine();
            }
        }

    }
}
