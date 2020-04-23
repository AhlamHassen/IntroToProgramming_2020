using System;

namespace numberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your first number");
            int n1 = int.Parse(Console.ReadLine()); //n1 = number1
            Console.WriteLine("please enter your second number");
            int n2 = int.Parse(Console.ReadLine()); //n2 = number2

            if (n1 + n2 == 10)
            {
                Console.WriteLine("The two numbers adds up to 10");
            }
            else if (n1 + n2 <= 10)
            {
                Console.WriteLine("The sum of the two numbers is less than 10");
            }
            else
            {
                Console.WriteLine("The sum of the two numbers is greater than 10");
            }
        }
    }
}
