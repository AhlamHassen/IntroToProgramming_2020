using System;
using System.Collections.Generic;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();

            Console.WriteLine("please enter a word to be stored");
            string input = Console.ReadLine();

            while (input != "stop")
            {
                words.Add(input);
                input = Console.ReadLine();

                if (input == "stop")
                {
                    Console.WriteLine("========================================================");
                    Console.WriteLine("The program has stoped | The stored words in reverse are");
                    Console.WriteLine("========================================================");
                    words.Reverse();

                    for (int i = 0; i < words.Count; i++)
                    {
                        Console.WriteLine(words[i]);
                    }

                }
            }
        }
    }
}
