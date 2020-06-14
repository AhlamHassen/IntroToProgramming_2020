using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace Assignment1___BingoNumberGenerator
{
    public class NumberDrawer
    {
        public int UpperLimit;
        public List<int> DrawnNumbers;
        public List<int> SortedList;

        public NumberDrawer()
        {
            this.UpperLimit = 0;
            this.DrawnNumbers = new List<int>();
            this.SortedList = new List<int>();
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
            Console.WriteLine("4. Check list of numbers");
            Console.WriteLine("5. Draw statistics");
            Console.WriteLine("6. Exit");

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
                this.printMenu();
            }

            else if (userSelection == "3")
            {
                Console.WriteLine(this.DrawnNumbers.Count + " number/s were drawn out of " + this.UpperLimit + " number/s . . .");
                Console.WriteLine("Press 123 to return to the main menu, enter a number to check if it has been drawn");
                this.userSelected();
                int selected = this.inputValidation();
                bool checker = false;

                while (selected != 123)
                {
                    for (int i = 0; i < this.DrawnNumbers.Count; i++)
                    {
                        if (selected == 123)
                        {
                            this.Menu();
                        }
                        else if (selected == this.DrawnNumbers[i])
                        {
                            checker = true;
                        }

                    }

                    if (checker == true)
                    {
                        Console.WriteLine("This number has been drawn . . .");
                        checker = false;
                    }
                    else
                    {
                        Console.WriteLine("This number has not been drawn . . .");
                    }

                    this.userSelected();
                    selected = this.inputValidation();
                }

                if (selected == 123)
                {
                    this.Menu();
                }
            }

            else if (userSelection == "4")
            {
                List<int> checkList = new List<int>();
                Console.WriteLine(this.DrawnNumbers.Count + " number/s were drawn out of " + this.UpperLimit +
                " number/s, Press 123 to go back to the main menu . . .");
                Console.WriteLine("Enter a list of numbers to check if the numbers have been drawn");

                this.userSelected();
                int selected = this.inputValidation();
                bool checker = false;

                if (selected == 123)
                {
                    this.Menu();
                }

                while (selected != 123)
                {
                    checkList.Add(selected);
                    this.userSelected();
                    selected = this.inputValidation();

                    if (selected == 123)
                    {
                        for (int i = 0; i < checkList.Count; i++)
                        {
                            for (int x = 0; x < this.DrawnNumbers.Count; x++)
                            {
                                if (checkList[i] == this.DrawnNumbers[x])
                                {
                                    checker = true;
                                }
                            }

                            if (checker == true)
                            {
                                Console.WriteLine("number " + checkList[i] + " has been drawn . . .");
                                checker = false;
                            }
                            else
                            {
                                Console.WriteLine("number " + checkList[i] + " has not been drawn . . .");
                            }

                        }
                        Console.WriteLine();
                        this.Menu();
                    }

                }

            }

            else if (userSelection == "5")
            {
                Console.WriteLine("1. Total of numbers drawn thus far");
                Console.WriteLine("2. Average of numbers drawn thus far");
                Console.WriteLine("3. Go back to main menu");

                this.userSelected();
                int selected = this.inputValidation();
                int total = 0;

                if (selected == 1)
                {
                    for (int i = 0; i < this.DrawnNumbers.Count; i++)
                    {
                        total += this.DrawnNumbers[i];
                    }
                    Console.WriteLine("The total is: " + total);
                    Console.WriteLine();
                    this.Menu();
                }
                else if (selected == 2)
                {
                    int average = 0;
                    for (int i = 0; i < this.DrawnNumbers.Count; i++)
                    {
                        total += this.DrawnNumbers[i];
                    }
                    for (int i = 0; i < this.DrawnNumbers.Count; i++)
                    {
                        average = total / this.DrawnNumbers.Count;
                    }
                    Console.WriteLine("The average is: " + average);
                    Console.WriteLine();
                    this.Menu();
                }
                else if (selected == 3)
                {
                    this.Menu();
                }
                else
                {
                    Console.WriteLine("Selected option is outside menu option range . . .");
                    this.Menu();
                }

            }

            else if (userSelection == "6")
            {
                Console.WriteLine("drawn_numbers.txt file has been created . . .");
                this.createFile();
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

        public void printMenu()
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
                this.SortedList.Sort();
                Console.Write("The drawn numbers are: ");

                for (int i = 0; i < this.DrawnNumbers.Count; i++)
                {
                    Console.Write(this.SortedList[i] + ", ");
                }
                Console.WriteLine();
                this.Menu();
            }

            else if (selected == 3)
            {
                this.Menu();
            }

            else
            {
                Console.WriteLine("Selected option is outside menu option range . . .");
                this.printMenu();
            }
            Console.WriteLine();
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
            while (this.DrawnNumbers.Contains(number) || this.SortedList.Contains(number));
            this.DrawnNumbers.Add(number);
            this.SortedList.Add(number);
            Console.WriteLine("The number drawn is: " + number);
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

        public void createFile()
        {
            string path = @"C:\Users\Ahlam\Desktop\myRepositories\IntroToProgramming_2020\Assignment1 - BingoNumberGenerator\drawn_numbers.txt";
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                using (StreamWriter sw = File.CreateText(path))
                {
                    if (this.DrawnNumbers.Count > 0)
                    {
                        sw.Write("The numbers drawn in their draw order are: ");
                        for (int i = 0; i < this.DrawnNumbers.Count; i++)
                        {
                            sw.Write(this.DrawnNumbers[i] + " ");
                        }
                        sw.WriteLine();

                        sw.Write("The numbers drawn in numerical order are: ");
                        this.DrawnNumbers.Sort();
                        for (int x = 0; x < this.DrawnNumbers.Count; x++)
                        {
                            sw.Write(this.DrawnNumbers[x] + " ");
                        }
                    }

                    else
                    {
                        sw.Write("No numbers were drawn");
                    }

                }

                //if you want the file contents to be displayed in the console 
                /*using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }*/

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

    }

}