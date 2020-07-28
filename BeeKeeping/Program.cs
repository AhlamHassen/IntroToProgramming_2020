using System;

namespace BeeKeeping
{
    class Program
    {
        static void Main(string[] args)
        {
          Bee b1 = new Bee("John", 3.2f);
          Bee b2 = new Bee("Paul", 2.7f);
          Bee b3 = new Bee("George", 1.1f);
          Bee b4 = new Bee("Ringo", 2.0f);

          //new bees for the second beehive
          Bee bee1 = new Bee("Kurt", 2.3f);
          Bee bee2 = new Bee("Dave", 7.4f);
          Bee bee3 = new Bee("Krist", 1.5f);
         

          Beehive Bh1 = new Beehive();
          Bh1.AddBees(b1);
          Bh1.AddBees(b2);
          Bh1.AddBees(b3);
          Bh1.AddBees(b4);

          //another way is to add the bees when istantiating use one of the costructors that allows that
          Beehive Bh2 = new Beehive(bee1, bee2, bee3);

          Bh1.collectHoney(10);
          Bh1.numberOfBees();

          Bh2.collectHoney(3);
          Bh2.numberOfBees();
          
        }
    }
}
