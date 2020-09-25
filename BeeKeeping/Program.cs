using System;
using System.Collections.Generic;

namespace BeeKeeping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bee> bees = new List<Bee>(){
                new Bee("John", 3.2f),
                new Bee("Paul", 2.7f),
                new Bee("George", 1.1f),
                new Bee("Ringo", 2.0f)
            };

            //new bees for the beehive 1
            Bee bee1 = new Bee("Kurt", 2.3f);
            Bee bee2 = new Bee("Dave", 7.4f);
            Bee bee3 = new Bee("Krist", 1.5f);

            //adding bees using the add bee method to the beehive created using default constructor;
            Beehive Bh1 = new Beehive();
            Bh1.AddBees(bee1);
            Bh1.AddBees(bee2);
            Bh1.AddBees(bee3);
            Bh1.addQueenBee();
            Bh1.AddBees(Bh1.QueenBee.makeBee("ahlam"));

            //create a beehive that takes a list of bees
            Beehive Bh2 = new Beehive(10, bees);

            Bh1.collectHoney(5);
            Bh1.numberOfBees();


        }
    }
}
