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
            int guess = 0;

            while (guess <= 100)
            {  guess++;

                if (input == answer)
                {
                    Console.WriteLine("your answer is correct!");
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
