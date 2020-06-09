using System;
using System.Collections.Generic;
using System.Linq;

namespace MyBingoGame
{
    public class BingoGame
    {
        public List<Card> listofCards = new List<Card>();
        public int maxValue;
        public int minValue;
        public int squareNum;

        public void Start()
        {
            Console.WriteLine("Select an Option: ");
            Console.WriteLine("1. Create Bingo Cards");
            Console.WriteLine("2. View and Mark Cards");
            Console.WriteLine("3. Exit");

            string userSelection = Console.ReadLine();

            if (userSelection == "1")
            {
                Console.WriteLine("How many cards would you like to create?");
                string CardNum = Console.ReadLine();
                Console.WriteLine("How many numbers on the Card? ");
                this.squareNum = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the minimum value? ");
                this.minValue = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the maximum value? ");
                this.maxValue = int.Parse(Console.ReadLine());

                Card c1 = new Card(this.squareNum, this.minValue, this.maxValue);
                c1.CreateCard();
                listofCards.Add(c1);

                Start();
            }

            else if (userSelection == "2")
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. View cards");
                Console.WriteLine("2. Mark Cards");
                Console.WriteLine("X. Go Back  ");

                string Selection = Console.ReadLine();
                if (Selection == "1")
                {
                    Console.Write("Enter card number: ");
                    var cardNum = int.Parse(Console.ReadLine());

                    var card = listofCards[cardNum - 1];
                    card.printCard();

                    Start();
                }

                else if (Selection == "2")
                {
                    Console.Write("Enter card number: ");
                    var cardNum = int.Parse(Console.ReadLine());
                    var card = listofCards[cardNum - 1];
                    card.printCard();
                    Console.Write("Enter the number to be marked: ");
                    var mark = int.Parse(Console.ReadLine());

                    card.markCard(mark);
                    Console.WriteLine();
                    //Start();
                }

            }

        }


    }


}
