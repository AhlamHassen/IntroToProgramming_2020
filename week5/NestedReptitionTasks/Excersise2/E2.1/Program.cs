using System;

namespace E2._1
{
    class Program
    {
        static void Main(string[] args)
        {   
            int counter=0;
            
            while(counter<5)
            {  
              int counter2=counter;
              while(counter2<5)
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
