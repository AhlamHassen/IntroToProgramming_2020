using System;
using System.Collections.Generic;
using System.Linq;

namespace MyBingoGame
{
    public class Card
    {
        public int Number;
        public int min;
        public int max;
        public List<int> Numbers;
        public List<int> usedNumber;

        public Card(int number, int min, int max)
        {
            this.Number = number;
            this.min = min;
            this.max = max;
            this.Numbers = new List<int>();
            this.usedNumber = new List<int>();
        }

        public void CreateCard()
        {


            for (int i = 0; i < this.Number; i++)
            {
                Random ran = new Random();
                var RandomNumber = ran.Next(this.min, this.max + 1);
                Numbers.Add(RandomNumber);
                usedNumber.Add(RandomNumber);
            }
            Numbers.Sort();
            usedNumber.Sort();

        }

        public void printCard()
        {   
            Console.WriteLine();
            int square = Convert.ToInt32(Math.Sqrt(this.Number));
            for (int x = 0; x < square; x++)
            {
                for (int i = 0; i < square; i++)
                {
                    //Console.Write(row[(a * square) + i]); // to sort in order of row
                    Console.Write(Numbers[(i * square) + x]);

                    if (Numbers[(i * square) + x] <= 9)
                    {

                        Console.Write("     | ");
                    }
                    else
                    {
                        Console.Write("    | ");
                    }

                }

                Console.WriteLine();
            }
            Console.WriteLine();
        }

        //*************************************************************************\\

        public void markCard( int mark)
        {
            for (int i = 0; i < this.Numbers.Count; i++)
            {
                if (mark == this.Numbers[i])
                {  
                   this.Numbers[i] = 11;
                    Console.WriteLine();
                }
                Console.Write(this.Numbers[i] + " |");

            }

        }

    }
}