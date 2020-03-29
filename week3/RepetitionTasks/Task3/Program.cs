using System;

namespace ProgTasksW5
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Guess The Number!");
            int x=5;
            int y= Convert.ToInt32(Console.ReadLine());

            if(y==x)
            {
                Console.WriteLine("you guessed it write!!");
            }
            else
            {
                 Console.WriteLine("Incorrect!Guess The Number Again");
            }  
             Console.ReadLine();
         
        }
    }
}
