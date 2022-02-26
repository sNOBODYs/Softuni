using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            CatalogueVehicle catalogueVehicle = new CatalogueVehicle();

            if (typeOfVehicle == "Car")
            {
                catalogueVehicle.Cars.Add(new Car
                {
                    Brand = brandOfVehicle,
                    Model = modelOfVehicle,
                    HorsePower = horseOrWeight
                });
            }
            else if (typeOfVehicle == "Truck")
            {
                catalogueVehicle.Trucks.Add(new Truck()
                {
                    Brand = brandOfVehicle,
                    Model = modelOfVehicle,
                    Weight = horseOrWeight
                });
            }
        }
    }
    class CatalogueVehicle
    {
        public List<Car> Cars { get; }
        public List<Truck> Trucks { get; }

        public CatalogueVehicle()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
    }
}
