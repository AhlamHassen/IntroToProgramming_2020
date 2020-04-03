using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {

            int moreX = 5;


            Console.WriteLine("Please Enter the amount of lines you want");
            int numsLine = int.Parse(Console.ReadLine());

            int space = numsLine;

            for (int i = 0; i < numsLine; i++)
            {
                for (int j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < (11 - 2 * moreX); j++)
                {
                    Console.Write("X");
                }
                moreX--;
                space--;
                Console.WriteLine();

            }


        }
    }
}
