using System;

namespace Excersise1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount that you want your name to be printed");
            int amount = Convert.ToInt32(Console.ReadLine());
            int counter = 1;
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();

            while (counter <= amount)
            {
                counter++;
                Console.Write(name + " ");

            }
        }
    }
}
