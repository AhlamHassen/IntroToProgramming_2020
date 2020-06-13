using System;
using System.Collections.Generic;

namespace Assignment1___BingoNumberGenerator
{
    public class NumberDrawer
    {
        public int UpperLimit;
        public List<int> DrawnNumbers;

        public NumberDrawer()
        {
            this.UpperLimit = 0;
            this.DrawnNumbers = new List<int>();
        }

        public void Start()
        {
            Console.WriteLine("Please enter the upper limit for the draw (input must be non-negative numeric value)");
            this.userSelected();
            this.UpperLimit = this.inputValidation();
            this.Menu();
        }

        public void Menu()
        {
            Console.WriteLine("Welcome to the Swinburne Bingo Club");
            Console.WriteLine("1. Draw next number");
            Console.WriteLine("2. View all drawn numbers");
            Console.WriteLine("3. Check specific number");
            Console.WriteLine("4. Exit");

            this.userSelected();
            string userSelection = Convert.ToString(this.inputValidation());

            int listCount = this.DrawnNumbers.Count;
            int limit = this.UpperLimit;

            if (userSelection == "1")
            {
                if (listCount == limit)
                {
                    Console.WriteLine("All numbers are drawn, you cannot draw more numbers . . .");
                    this.Menu();
                }
                else
                {
                    this.generateRandomNum();
                    this.Menu();
                }
            }

            else if (userSelection == "2")
            {
                Console.WriteLine("Print all drawn numbers");
                Console.WriteLine("1. Print all numbers in the order that they were drawn");
                Console.WriteLine("2. Print all numbers in numerical order");
                Console.WriteLine("3. Go back to main menu");

                this.userSelected();
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

                else if (selected == 2)
                {
                    this.DrawnNumbers.Sort();
                    Console.Write("The drawn numbers are: ");
                    for (int i = 0; i < this.DrawnNumbers.Count; i++)
                    {
                        Console.Write(this.DrawnNumbers[i] + ", ");
                    }
                    Console.WriteLine();
                    this.Menu();
                }

                else if (selected == 3)
                {
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

            else
            {
                Console.WriteLine("Selected option is outside menu option range . . .");
                this.Menu();
            }

        }

        public void userSelected()
        {
            Console.WriteLine();
            Console.Write("User selected: ");
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
                    this.userSelected();
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