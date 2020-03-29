using System;

namespace E2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter=0;
            Console.WriteLine("enter the amount of starting X's");
            int amount=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            while(counter<5)
            {  
              int counter2=counter;
              while(counter2<amount)
               { 
                 counter2++;
                 Console.Write("X");
               }
              Console.WriteLine();
              counter++;
            }
        }
    }
}
