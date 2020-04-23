using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=1;
            while(x<=100)
            {   if(x%3==0 || x%5==0)
                {
                   if(x%3==0 && x%5==0)
                   {
                       Console.WriteLine("FizzBuzz");
                       x++;
                   }
                   else if(x%3==0)
                   {
                     Console.WriteLine("Fizz");
                     x++;
                   }
                   else
                   {
                     Console.WriteLine("Buzz");
                     x++;
                   }
                }

                else
                {
                    Console.WriteLine(x);
                    x++;
                }
            }
        }
    }
}
