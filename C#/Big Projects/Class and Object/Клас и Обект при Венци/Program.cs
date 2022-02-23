using System;

namespace Клас_и_Обект_при_Венци
{
    class Program
    {
    
        static void Main(string[] args)
        {
            Point p1 = new Point(23.00 , 12.00 , "A");
            Point p2 = new Point(12.00, 14.00, "B");
            Point[] points = new Point[5];
            points[0] = new Point(45, 13, "c");
            points[1] = new Point(75, 13, "d");
            points[2] = new Point(56, 13, "e");
            points[3] = new Point(11, 13, "f");
            points[4] = new Point(15, 13, "g");

            double maxD = 0;

            for (int i = 0; i < points.Length; i++)
            {
                for (int g = 0; g < i; g++)
                {
                    Console.WriteLine(points[i].Name + points[g].Name + " ");
                    double dist = Distance(points[i], points[g]);
                    if (maxD < dist)
                    {
                        maxD = dist;
                    }
                }
            }
        }
        static double Distance (Point p1, Point p2)
        {
            double varaeble = Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y , 2));
            return varaeble;
        }
        
    }
    class Point
    {
        public string Name { get; set; }
        public double x { get; set; }
        public double y { get; set; }
        

        public Point(double x, double y, string name)
        {
            this.Name = name;
            this.x = x;
            this.y = y;
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1:f2}, {2:f2}", this.Name , this.x , this.y);
        }
    }

    class Circle
    {
        public string Name { get; set; }
        public Point Center { get; set; }
        public double Radius { get; set; }

        public override string ToString()
        {
            return string.Format("{0}({1},{2:f2})", this.Name, this.Center, this.Radius);
        }
    }

}
