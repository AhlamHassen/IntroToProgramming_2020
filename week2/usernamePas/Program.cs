using System;

namespace prog
{
    class Program
    {
        static void Main(string[] args)
        {
          string username="Ahlam";
          int password=12345;
          Console.WriteLine("please enter your username");
          string input=Console.ReadLine();
          if(username==input)
          {
              Console.WriteLine("please enter your password");
              int pas= Convert.ToInt32(Console.ReadLine());
              if(pas==password)
              {
                  Console.WriteLine("login successful");
              }
              else
              {
                  Console.WriteLine("login unsuccessful");
              }
          }
          else
          {
              Console.WriteLine("login unsuccessful");
          }
        }
    }
}
