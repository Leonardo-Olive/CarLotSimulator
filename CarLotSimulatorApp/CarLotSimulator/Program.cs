using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();
            
            //DOne -Create a seperate class file called Car -Done
            //Done-Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Done -Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //Done - The methods should take one string parameter: the respective noise property


            //DOne- Now that the Car class is created we can instanciate 3 new cars
            var Corolla = new Car();
            //Set the properties for each of the cars
            Corolla.Make = "Toyota";
            Corolla.Model = "Corolla";
            Corolla.Year = 2022;
            Corolla.EngineNoise = "Vroom";
            Corolla.HonkNoise = "Beep";
            Corolla.IsDrivable = true;

            lot.Cars.Add(Corolla);


            var Tesla = new Car()
            {
                Make = "Tesla",
                Model = "Y",
                Year = 2023,
                EngineNoise = "...",
                HonkNoise = "Brrrrp",
                IsDrivable = true
                
            };

            lot.Cars.Add(Tesla);


            var Q5 = new Car(2022, "Audi", "Q5", "Vroom", "Bomp", true);
            lot.Cars.Add(Q5);



            //Done--Call each of the methods for each car
            Corolla.MakeEngineNoise(Corolla.EngineNoise);
            Tesla.MakeEngineNoise(Tesla.EngineNoise);
            Q5.MakeEngineNoise(Q5.EngineNoise);

            //*************BONUS*************//

            //Done-- Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Done- Create a CarLot class
            //Done -It should have at least one property: a List of cars
            //Done-Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //Done--At the end iterate through the list printing each of car's Year, Make, and Model to the console


            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }
    }
}
