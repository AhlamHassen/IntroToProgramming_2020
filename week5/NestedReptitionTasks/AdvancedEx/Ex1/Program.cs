using System;

namespace Excersise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int loopcount=7;
            
            while (counter < 12)
            {   
                loopcount--;
            
                int counter2 = counter;
                while (counter2 <= 10)
                {
                    Console.Write("X");
                    counter2++;
                }
                
                Console.WriteLine();
                counter = counter + 2;
              
            }
        }
    }
}
