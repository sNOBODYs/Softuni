using System;
using System.Collections.Generic;
using System.Text;

namespace Fields_Demo
{
    public class Engine
    {
        private int speed;
        private int horsePower;
        public Engine(int speed, int horsePower)
        {
            HorsePower = horsePower;
            Speed = speed;
        }
        public int HorsePower
        {
            get { return horsePower; }
            set { horsePower = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

    }
}
