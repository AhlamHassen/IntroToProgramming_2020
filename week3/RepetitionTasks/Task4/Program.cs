using System;

namespace ProgTasksW5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");
            int input=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int x=0;
            while(x<=input)
            {
              Console.WriteLine(x);
              x++;
            }
            
        }
    }
}
