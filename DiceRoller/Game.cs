using System;
using System.Collections.Generic;

namespace DiceRoller
{
    public class Game
    {
        Person p1;
        Person p2;

        public Game(string p1Name, string p2Name){
            p1= new Person(p1Name,new List<Die>());
            p2= new Person(p2Name,new List<Die>());
        }

        public void Start(){
            Console.WriteLine("Welcome to DiceRoller!");
            Console.WriteLine("1. Add dice to player");
            Console.WriteLine("2. Roll dice ");
            Console.WriteLine("3. View player information");
            Console.Write("Selection: ");

            var userSelection = Console.ReadLine();

            if(userSelection == "1"){
                AddDiceToPlayer();
            }
            else if(userSelection == "2"){
               RollDice();
            }
            else if(userSelection == "3"){
                ViewInfo();
            }

            Start();
        }

        public void AddDiceToPlayer(){
            Console.WriteLine("Select player");
            var userSelection = Console.ReadLine();
            Console.Write ("How many Sides ");
            var sides= int.Parse(Console.ReadLine());
            
            
            if(userSelection == "1"){
               p1.AddNewDie(sides);
            }
            else if(userSelection == "2"){
                p2.AddNewDie(sides);
            }

            Start();
        }
        
        public void ViewInfo(){
            Console.WriteLine("Select Player");
            var userSelection= Console.ReadLine();

            if(userSelection == "1"){
                Console.WriteLine(p1.Name);
                Console.WriteLine(p1.Dice.Count);
            }
            else if(userSelection == "2"){
                Console.WriteLine(p2.Name);
                Console.WriteLine(p2.Dice.Count);
            }
            
            Start();
        }

        public void  RollDice(){
            Console.WriteLine("Select Player");
            var userSelection = Console.ReadLine();
           
            if(userSelection == "1"){
                int roll = -1;
                if(p1.Dice.Count > 0){
                    Console.WriteLine("which die do you want to roll ");
                    int die = int.Parse(Console.ReadLine());
                    roll = p1.Dice[die].Roll();
                    Console.WriteLine(roll);
                } 
            }

            Start();
        }
    }
}