using System;
using System.Collections.Generic;

namespace BeeKeeping
{
    public class Beehive
    {
        public List<Bee> Bees;
        public int MaxAmountOfBees;
        public QueenBee QueenBee;

        
        public Beehive(){
            this.Bees = new List<Bee>();
            this.MaxAmountOfBees = 4;
            this.QueenBee = null;
        }

        public Beehive(int max , List<Bee> bees){
            this.MaxAmountOfBees = max;
            this.Bees = bees;
            this.QueenBee = null;
        }

        public void AddBees(Bee bee){
            this.Bees.Add(bee);
        }

        public void collectHoney(int days){
            foreach ( Bee b in this.Bees){
               float Amount = days * b.Size * 0.2f;
               Console.WriteLine($"The amount of honey collectd by {b.Name} in {days} days is: {Amount}" );
               // Convert.ToSingle() - to conver a dobule to float 
            }
          
        }

        public void numberOfBees(){
           Console.WriteLine($"The number of bees in this hive are: {this.Bees.Count}");
        }

        public void addQueenBee(){
            this.QueenBee = new QueenBee();
        } 


    }
}