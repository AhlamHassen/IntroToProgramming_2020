using System;
using System.Collections.Generic;

namespace ExceptionHaTask
{
    public class Menu
    {

        string message;

        public Menu()
        {
            this.message = "Please fill the required fields";
        }
        
        public void menu()
        {
            List<Student> students = new List<Student>();
            Student s1 = new Student();
            string input;
           
            Console.WriteLine(this.message);
            Console.Write("Room Number: ");
            s1.roomNumber = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Name: ");
            s1.Name = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter date entered in the format of(MM/DD/YY): ");
            try
            {
                s1.dateEntered = DateTime.Parse(Console.ReadLine());

            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Wrong datatype was entered, {ex.Message}, You will have to restart");
                this.menu();
            }
            Console.WriteLine();


            Console.Write("Enter time entered in the format of (hh:mm ): ");
            try
            {
                s1.TimeEntered = DateTime.Parse(Console.ReadLine());

            }
            catch (NullReferenceException ex)
            {
                System.Console.WriteLine($"Object doesn't exist :( Closing Program - {ex.Message},You will have to restart ");
                this.menu();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops!! Something went wrong, {ex.Message},You will have to restart");
                this.menu();
            }
            Console.WriteLine();

            Console.Write("Enter date left in the format of(MM/DD/YY): ");
            try
            {
                s1.dateLeft = DateTime.Parse(Console.ReadLine());

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops!! Something went wrong, {ex.Message},You will have to restart");
                this.menu();
            }
            Console.WriteLine();


            Console.Write("Enter time left in the format of (hh:mm ): ");
            try
            {
                s1.TimeLeft = DateTime.Parse(Console.ReadLine());

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops!! Something went wrong, {ex.Message},You will have to restart");
                this.menu();
            }
            Console.WriteLine();

            Console.WriteLine("Do you want to know how long you have stayed in class in Minutes. Answer yes/no");
            input = Console.ReadLine();

            if (input == "Yes" || input == "yes" || input == "YES")
            {
                timeDifference(s1.dateEntered, s1.TimeEntered, s1.dateLeft, s1.TimeLeft);
            }
            else
            {
                Console.WriteLine("Please continue ...");
            }

            students.Add(s1);
            Console.WriteLine();

        }

        public void start()
        {
            string input;
            this.menu();
            Console.WriteLine("Do you want to enter another student's details? answer with Yes/NO");
            input = Console.ReadLine();

            if (input == "Yes" || input == "yes" || input == "YES")
            {
                this.menu();
            }
            else if (input == "No" || input == "no" || input == "NO")
            {
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Invalid input!! the system will exit");
                System.Environment.Exit(1);
            }
        }

        // public void timeDifference(DateTime dentered, DateTime tentered, DateTime dlef, DateTime tleft)
        // {
        //     DateTime adate = dentered;
        //     DateTime bdate = dlef;
        //     DateTime atime = tentered;
        //     DateTime btime = tleft;

        //     var dateInMin = bdate.Subtract(adate).TotalMinutes;
        //     var TimeInMin = btime.Subtract(atime).TotalMinutes;

        //     double value = dateInMin + TimeInMin;
        //     Console.WriteLine(value);
           
        // }

         public double timeDifference(DateTime dentered, DateTime tentered, DateTime dlef, DateTime tleft)
        {
            DateTime adate = dentered;
            DateTime bdate = dlef;
            DateTime atime = tentered;
            DateTime btime = tleft;

            var dateInMin = bdate.Subtract(adate).TotalMinutes;
            var TimeInMin = btime.Subtract(atime).TotalMinutes;

            double value = dateInMin + TimeInMin;
           // Console.WriteLine(value);
            
            return value;
        }
    }
}