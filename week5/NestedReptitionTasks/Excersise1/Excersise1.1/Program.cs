using System;

namespace Excersise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter you name");
            string name = Console.ReadLine();
            Console.WriteLine("");
            int counter = 0;

            while (counter < 10)
            {
                counter++;
                Console.Write(name + " ");
            }
            
        }
    }
}
