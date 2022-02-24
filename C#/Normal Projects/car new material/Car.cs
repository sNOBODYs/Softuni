using System;
using System.Collections.Generic;
using System.Text;

namespace Fields_Demo
{
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tire[] tires;

        public Car(string model, Engine eng, Cargo cargo, Tire[] tires)
        {
            Tires = tires;
            Cargo = cargo;
            Engine = eng;
            Model = model;
        }
        public Tire[] Tires
        {
            get { return tires; }
            set { tires = value; }
        }

        public Cargo Cargo
        {
            get { return cargo; } 
            set {cargo = value; }
        }
        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }



        public string Model
        {
            get { return model; }
            set { model = value; }
        }

    }
}
