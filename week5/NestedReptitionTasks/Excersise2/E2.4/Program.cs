using System;

namespace E2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Console.WriteLine("please enter the number of lines you want");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            while (counter < inputNumber)
            {
                int counter2 = counter;
                while (counter2 >= 0 )
                {
                    Console.Write("X");
                    counter2--;
                }

                Console.WriteLine();
                counter++;
            }
        }
    }
}