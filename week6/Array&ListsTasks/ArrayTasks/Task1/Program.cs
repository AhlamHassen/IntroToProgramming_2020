using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            Console.WriteLine("Please enter Five names");

            for (int i = 0; i < names.Length; i++)
            {
                string input = Console.ReadLine();
                names[i] = input;
            }

            Console.WriteLine("=============================");

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Hello " + names[i] + ".");
            }

        }
    }
}
