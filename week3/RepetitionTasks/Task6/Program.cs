using System;

namespace ProgTasksW5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 653;
            /* Random generateRandom = new Random();
             int num = generateRandom.Next(1,1000); */
             
            int counter = 0;
            Console.WriteLine("Guess a number between 1 and 1000");

            while (counter < 10)
            {
                int guess = Convert.ToInt32(Console.ReadLine());
                counter++;
                if (guess == num)
                {
                    Console.WriteLine("Congratulations!You guessed the number!");
                    break;
                }
                else
                {
                    if (counter >= 10)
                    {
                        Console.WriteLine("you have zero guess left");
                        Console.WriteLine("Good Luck next time!!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!Try again");
                    }

                }
            }
        }
    }
}
