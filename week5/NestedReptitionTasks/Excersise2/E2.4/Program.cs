using System;

namespace E2._4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("please enter the number of lines you want");
            int counter = Convert.ToInt32(Console.ReadLine());
            int input = counter;
            Console.WriteLine();

            while (counter > 0)
            {
                counter--;
                int counter2 = counter;
                while (counter2 < input)
                {
                    counter2++;
                    Console.Write("X");
                }
                Console.WriteLine();

            }
        }
    }
}