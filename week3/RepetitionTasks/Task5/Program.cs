using System;

namespace ProgTasksW5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What happens when you throw a yellow rock in the red sea?");
            string input = Console.ReadLine();
            string answer = "it gets wet";
            bool found = false;

            while (found != true)
            {
                if (input == answer)
                {
                    Console.WriteLine("your answer is correct!");
                    found = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect!Try again");
                }
                input = Console.ReadLine();
            }
            
        }
    }
}
