using System;

namespace week8
{
    class Program
    {
        static void Main(string[] args)
        { 
            Colour red = new Colour(255, 0, 0, "Red");
            Colour green = new Colour(0, 255, 0, "green");
            Colour blue = new Colour(0, 0, 255, "blue");
            
            //Code to instantiate a cookie
            Cookie c1 = new Cookie(12, "circle", red);
            Cookie c2 = new Cookie(19, "rectangle", green);
            Cookie c3 = new Cookie(15, "oval", blue);
            Cookie c4 = new Cookie(9, "star", red);

            Console.WriteLine("The colour of cookie 1 is: " + c1.colour.colorName);
            Console.WriteLine("The colour of cookie 2 is: " + c2.colour.colorName);

            
        }
    }

    class Cookie
    {
      public int weight;
      public string shape;
      public Colour colour;

      public Cookie(int we, string sh, Colour c){
          this.weight = we;
          this.shape = sh;
          this.colour = c;
      }

    }

    class Colour
    {
        public int red;
        public int green;
        public int blue;
        public string colorName;

        public Colour(int r, int g, int b, string cn){
            this.red = r;
            this.green = g;
            this.blue = b;
            this.colorName = cn;
        }
    }
}
