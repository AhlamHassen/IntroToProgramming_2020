using System;

namespace week8
{
    class Program
    {
        static void Main(string[] args)
        {    
            //code to instantiate a Colour
            Colour c1 = new Colour(255, 0, 0, "red");
            Colour c2 = new Colour(0, 0, 255, "blue");
            Colour c3 = new Colour(0, 255, 0, "green");

            //code to instantiate a Cookie
            Cookie ck1 = new Cookie(12, "circle", c1);
            Cookie ck2 = new Cookie(10, "oval", c2);
            Cookie ck3 = new Cookie(9, "rectangle", c3);
            Cookie ck4 = new Cookie(15, "circle", c1);

            Console.WriteLine("The colour of cookie 1 is: " + c1.colourName);
            Console.WriteLine("The colour of cookie 2 is: " + c2.colourName);
           
        }

    }

    class Cookie
    {
        public int Weight;
        public string Shape;
        public Colour Colour;

        //=====================
        //constructor
        //=====================
        public Cookie(int weight, string shape, Colour c)
        {
            this.Weight = weight;
            this.Shape = shape;
            this.Colour = c;
        }

    }

    class Colour
    {
        public int red;
        public int green;
        public int blue;
        public string colourName;

        public Colour(int red, int green, int blue, string name)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.colourName = name;

        }
    }

}




