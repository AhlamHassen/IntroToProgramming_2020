using System;
using System.Collections.Generic;

namespace Assignment1___BingoNumberGenerator
{
    public class NumberDrawer
    {
        public uint UpperLimit;
        public List<int> DrawnNumbers;


        public NumberDrawer()
        {
            this.UpperLimit = 0;
            this.DrawnNumbers = new List<int>();
        }

        public void Start()
        {
            string numberRead;
            int counter = 0;
            do
            {
                if (counter > 0)
                {
                    Console.WriteLine("Invalid input!");
                }
                Console.WriteLine("Please enter the upper limit for the draw (input must be non-negative numeric value)");
                numberRead = Console.ReadLine();
                counter++;
            }
            while (!uint.TryParse(numberRead, out this.UpperLimit));
            Console.WriteLine();
            this.Menu();

        }

        public void Menu()
        {
            Console.WriteLine("Welcome to the Swinburne Bingo Club");
            Console.WriteLine("1. Draw next number");
            Console.WriteLine("2. View all drawn numbers");
            Console.WriteLine("3. Check specific number");
            Console.WriteLine("4. Exit");

            var userSelection = Console.ReadLine();
            Console.WriteLine();

            if (userSelection == "1")
            {
                this.generateRandomNum();
                int listCount = this.DrawnNumbers.Count;
                int limit = Convert.ToInt32(this.UpperLimit);

                if(listCount == limit){
                    Console.WriteLine("All numbers are drawn, you cannot draw more numbers");
                
                }
                this.Menu();
            }

            else if (userSelection == "2")
            {
                Console.WriteLine("1. Print all numbers in the order that they were drawn");
                Console.WriteLine("2. Print all numbers in numerical order");
                Console.WriteLine("3. Go back");
                int selected = this.inputValidation();

                if (selected == 1)
                {
                    Console.Write("The drawn numbers are: "); 
                    for (int i = 0; i < this.DrawnNumbers.Count; i++)
                    {
                        Console.Write(this.DrawnNumbers[i] + ", ");
                    }
                    Console.WriteLine();
                    this.Menu();
                }
                else if( selected == 2){
                    this.DrawnNumbers.Sort();
                    Console.Write("The drawn numbers are: "); 
                    for (int i = 0; i < this.DrawnNumbers.Count; i++){
                        Console.Write(this.DrawnNumbers[i] + ", ");
                    }
                    Console.WriteLine();
                    this.Menu();

                }
                else if( selected == 3){
                    this.Menu();
                }
                Console.WriteLine();

            }

            else if (userSelection == "3")
            {

            }
            else if (userSelection == "4")
            {
               return;
            }



        }

        public void generateRandomNum()
        {  
            Random ran = new Random();
            int limit = Convert.ToInt32(this.UpperLimit);
            int number;
            do
            {
                number = ran.Next(1, limit + 1);
                if (number < 0)
                {
                    number = number * -1;
                }

            }
            while (this.DrawnNumbers.Contains(number));
            this.DrawnNumbers.Add(number);
            Console.WriteLine(number);
            Console.WriteLine();
        }

        public int inputValidation()
        {
            string numberRead;
            uint Selected;
            int counter = 0;
            do
            {
                if (counter > 0)
                {
                    Console.WriteLine("Invalid input!");
                }

                numberRead = Console.ReadLine();
                counter++;
            }
            while (!uint.TryParse(numberRead, out Selected));
            Console.WriteLine();

            int numSelected = Convert.ToInt32(Selected);
            return numSelected;
        }







    }



}