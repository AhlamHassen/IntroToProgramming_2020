using System;

namespace E2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 5;

            while (counter > 0)
            {
                counter--;
                int counter2 = counter;
                while (counter2 < 5)
                {
                    counter2++;
                    Console.Write("X");
                }
                Console.WriteLine();

            }
        }
    }
}
