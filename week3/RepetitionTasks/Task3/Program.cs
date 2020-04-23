using System;

namespace ProgTasksW5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess The Number!");
            int x = 5;
            bool found = false;
            int y = Convert.ToInt32(Console.ReadLine());
            while (found != true)
            {
                if (y == x)
                {
                    Console.WriteLine("you guessed it write!!");
                    found = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect!Guess The Number Again");
                }
                y = Convert.ToInt32(Console.ReadLine());


            }

        }
    }
}
