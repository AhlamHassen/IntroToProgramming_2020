using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 34, 5, 67, 1, 99, 34, 44, 78, 34, 0 };
            int total = 0;

            for (int i = 0; i < num.Length; i++)
            {
                total += num[i];
            }
            Console.WriteLine("the sum of the numbers is " + total);

        }
    }
}
