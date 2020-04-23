using System;

namespace Excersise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int space = 0;

            while (counter < 12)
            {
                for (int i = 0; i < space; i++)
                {
                    Console.Write(" ");
                }

                int counter2 = counter;
                while (counter2 < 11)
                {
                    Console.Write("X");
                    counter2++;
                }

                Console.WriteLine();
                counter += 2;
                space++;
            }

            // Using for Loop

            /* int LessX = 0;
               int space = 0;

              for (int i = 0; i < 6; i++)
              {
                  for (int j = 0; j < space; j++)
                  {
                      Console.Write(" ");
                  }
                  for (int j = 0; j < (11 - 2 * LessX); j++)
                  {
                      Console.Write("X");
                  }
                  Console.WriteLine();
                  LessX++;
                  space++; 
              }*/

        }
    }
}
