using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int moreX = 5;
            int space = 5;

            for (int i = 0; i < 6; i++)
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
