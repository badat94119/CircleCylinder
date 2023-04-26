using System;

namespace CircleAndCylinder
{
    class Circle
    {
        private double radius;
        private string color;

        // Constructors
        public Circle()
        {
            radius = 1.0;
            color = "white";
        }

        public Circle(double r, string c)
        {
            radius = r;
            color = c;
        }

        // Getters and setters
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        // Calculate area
        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

        // Override ToString method
        public override string ToString()
        {
            return "Circle:\n" +
                   "Radius: " + radius + "\n" +
                   "Color: " + color + "\n" +
                   "Area: " + GetArea();
        }
    }

    // Cylinder class derived from Circle class
    class Cylinder : Circle
    {
        private double height;

        // Constructors
        public Cylinder() : base()
        {
            height = 1.0;
        }

        public Cylinder(double r, string c, double h) : base(r, c)
        {
            height = h;
        }

        // Getters and setters
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        // Calculate volume
        public double GetVolume()
        {
            return GetArea() * height;
        }

        // Override ToString method
        public override string ToString()
        {
            return "Cylinder:\n" +
                   "Radius: " + Radius + "\n" +
                   "Color: " + Color + "\n" +
                   "Height: " + height + "\n" +
                   "Volume: " + GetVolume();
        }
    }

    // Test program
    class Program
    {
        static void Main(string[] args)
        {
            // Test Circle class
            Circle c1 = new Circle();
            Console.WriteLine("Circle 1:\n" + c1.ToString());

            Circle c2 = new Circle(5, "red");
            Console.WriteLine("Circle 2:\n" + c2.ToString());

            // Test Cylinder class
            Cylinder cy1 = new Cylinder();
            Console.WriteLine("Cylinder 1:\n" + cy1.ToString());

            Cylinder cy2 = new Cylinder(3, "green", 10);
            Console.WriteLine("Cylinder 2:\n" + cy2.ToString());

            // Test getters and setters
            c1.Radius = 2;
            c1.Color = "blue";
            Console.WriteLine("Circle 1 (updated):\n" + c1.ToString());

            cy1.Radius = 4;
            cy1.Color = "yellow";
            cy1.Height = 7;
            Console.WriteLine("Cylinder 1 (updated):\n" + cy1.ToString());

            // Test area and volume methods
            Console.WriteLine("Area of Circle 1: " + c1.GetArea());
            Console.WriteLine("Volume of Cylinder 2: " + cy2.GetVolume());

            // Test ToString method
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());
            Console.WriteLine(cy1.ToString());
            Console.WriteLine(cy2.ToString());
        }
    }
}