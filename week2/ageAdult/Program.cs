using System;

namespace ageAdult
{
    class Program
    {
        static void Main(string[] args)
        {
            string female="f" , male="m";
            Console.WriteLine("please enter your gender");
            string gender=Console.ReadLine();
            if(gender==female)
            {
                Console.WriteLine("F");
            }
            else if(gender==male)
            {
               Console.WriteLine("M");
            }
            Console.WriteLine("please enter your age");
            int age=Convert.ToInt32(Console.ReadLine());
            if(age>17)
            {
                Console.WriteLine(gender + " is an adult"); 
            }
            else
            {
                Console.WriteLine(gender + " is not an adult"); 
            }
        }
    }
}
