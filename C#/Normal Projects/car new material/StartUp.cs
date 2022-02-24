using System;
using System.Collections.Generic;
using System.Linq;

namespace Fields_Demo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();

                string model = info[0];
                int engineSpeed = int.Parse(info[1]);
                int enginePower = int.Parse(info[2]);
                Engine eng = new Engine(engineSpeed, enginePower);
                int weight = int.Parse(info[3]);
                string typeCargo = info[4];
                Cargo cargo = new Cargo(weight, typeCargo);
                Tire[] tires = new Tire[4];
                int count = 0;
                for (int j = 5; j < info.Length; j+= 2)
                {
                    Tire current = new Tire(int.Parse(info[j + 1]), double.Parse(info[j]));
                    tires[count] = current;
                    count++;
                }
                Car currentCar = new Car(model, eng, cargo, tires);
                cars.Add(currentCar);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                List<Car> carsWithFragile = cars.Where(x => x.Cargo.Type == command).ToList();
                foreach (var car in carsWithFragile)
                {
                    for (int i = 0; i < car.Tires.Length; i++)
                    {
                        if (car.Tires[i].Pressure < 1)
                        {
                            Console.WriteLine(car.Model);
                            break;
                        }
                    }
                }
            }
            else
            {
                List<Car> flamable = cars
                    .Where(x => x.Cargo.Type == command && x.Engine.HorsePower > 250)
                    .ToList();
                foreach (var car in flamable)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
