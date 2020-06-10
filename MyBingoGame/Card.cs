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
        public List<string> usedNumber;

        public Card(int number, int min, int max)
        {
            this.Number = number;
            this.min = min;
            this.max = max;
            this.Numbers = new List<int>();
            this.usedNumber = new List<string>();
        }

        public void CreateCard()
        {


            for (int i = 0; i < this.Number; i++)
            {
                Random ran = new Random();
                var RandomNumber = ran.Next(this.min, this.max + 1);
                Numbers.Add(RandomNumber);

                //usedNumber.Add(Convert.ToString(RandomNumber));
            }
            Numbers.Sort();
            for (int i = 0; i < this.Number; i++){
                usedNumber.Add(Convert.ToString(Numbers[i]));
            }

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
                    //I am using the used number which is string of the same number to 
                    // mark them
                    Console.Write(usedNumber[(i * square) + x]);

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
                    this.usedNumber[i] = "X";
                    Console.WriteLine();
                }
            
            }
            this.printCard();

        }

    }
}