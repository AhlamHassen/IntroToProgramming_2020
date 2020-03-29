using System;

namespace numberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your first number");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter your second number");
            int n2=Convert.ToInt32(Console.ReadLine());
            if(n1+n2==10)
            {
                 Console.WriteLine("The two numbers adds up to 10");
            }
            else if(n1+n2<=10)
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
