using System;
using System.Collections.Generic;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Die d1 = new Die();
            Die d2 = new Die(12);
            Die d3 = new Die(20);

            List<Die> diceList1 = new List<Die>();
            diceList1.Add(d1);
            diceList1.Add(d2);
            diceList1.Add(d3);

            List<Die> diceList2 = new List<Die>();
            diceList2.Add(d2);

            Person p1 = new Person("William Wallace", diceList1);
            Person p2 = new Person("Joan of Arc", diceList2);

             System.Console.WriteLine(p1.Name);
             System.Console.WriteLine(p1.Dice.Count);

             System.Console.WriteLine(p2.Name);
             System.Console.WriteLine(p2.Dice.Count);
             p2.AddNewDie(18);
             System.Console.WriteLine(p2.Dice.Count);

            for (int i = 0; i < 20; i++)
            {
                // roll William Wallace's second die
                System.Console.WriteLine(p1.RollDie(4));
            }

            // roll William Wallace's All dice
            int rollValue = p1.RollAllDice();
            System.Console.WriteLine(rollValue);*/

            Game g = new Game("Ahlam", "Alu");
            g.Start();
            

        }
    }

}
