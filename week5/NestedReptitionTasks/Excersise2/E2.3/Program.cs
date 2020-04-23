using System;

namespace E2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            while (counter < 5)
            {
                int counter2 = counter;
                while (counter2 >= 0)
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
