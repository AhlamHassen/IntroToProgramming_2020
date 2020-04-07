using System;
using System.Collections.Generic;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
           List<int> num = new List<int>();
            Console.WriteLine("Please insert 5 numbers");
            int Counter = 0;

            while (Counter < 5)
            {
                int input = int.Parse(Console.ReadLine());
                num.Add(input);
                Counter++;
            }

            Console.WriteLine("Please insert a number");

            int x = int.Parse(Console.ReadLine());
            bool found = false;
            int counter=0;
            
            for (int i = 0; i < num.Count; i++)
            {
                if (x == num[i])
                {
                    found = true;
                    counter++;
                }
            }

            if (found == true)
            {
                Console.WriteLine("This Number has already been entered" + " " + counter + " "+ "times");
            }
            else
            {
                Console.WriteLine("This Number has not been entered");
            }
        }
    }
}
