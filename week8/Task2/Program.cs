using System;
using System.Collections.Generic;

namespace week8
{
    class Program
    {
        static void Main(string[] args)
        {  
            //instantiating a person
            Person p1 = new Person("Ahlam", "Hassen", 1997, 154);
            Person p2 = new Person("Amiiy", "Saleh", 2000, 163);
            Person p3 = new Person("Dina", "Adem", 1998, 170);

            Console.WriteLine("Person 1:");
            p1.GetFullName(p1.Firstname, p1.Surname);
            Console.Write("Height difference form Person 2 is: ");
            p1.GetHeightDifference(p1.Height, p2.Height);
            Console.Write("Height difference form Person 3 is: ");
            p1.GetHeightDifference(p1.Height, p3.Height);
            Console.WriteLine();

            Console.WriteLine("Person 2:");
            p2.GetFullName(p2.Firstname, p2.Surname);
            Console.Write("Height difference form Person 1 is: ");
            p2.GetHeightDifference(p2.Height, p1.Height);
            Console.Write("Height difference form Person 3 is: ");
            p2.GetHeightDifference(p2.Height, p3.Height);
            Console.WriteLine();

            Console.WriteLine("Person 3:");
            p3.GetFullName(p3.Firstname, p3.Surname);
            Console.Write("Height difference form Person 1 is: ");
            p3.GetHeightDifference(p3.Height, p1.Height);
            Console.Write("Height difference form Person 2 is: ");
            p3.GetHeightDifference(p3.Height, p2.Height);
            Console.WriteLine();

            Random ran = new Random();
            int random = ran.Next(1, 1000);

            Random ran2 = new Random();
            int random2 = ran2.Next(1, 1000);

            Random ran3 = new Random();
            int random3 = ran3.Next(1, 1000);

            p1.Id = random;
            p2.Id = random2;
            p3.Id = random3;

            Console.WriteLine("The ID of Person 1 is: " + p1.Id);
            Console.WriteLine("The ID of Person 2 is: " + p2.Id);
            Console.WriteLine("The ID of Person 3 is: " + p3.Id);
            Console.WriteLine();

            Subject En = new Subject("English", 2020);
            p1.newSubject(En);
            
        }
    }

    class Person
    {
        public string Firstname;
        public string Surname;
        public int Dob;
        public int Height;
        public int Id;
        public List<Subject> ListOfSubjects;

        //=========================
        public Person(string fname, string sname, int dob, int ht)
        {
            this.Firstname = fname;
            this.Surname = sname;
            this.Dob = dob;
            this.Height = ht;
            this.Id = 0;
            this.ListOfSubjects = new List<Subject>();

        }
        //==========================

        public void GetFullName(string fname, string sname)
        {
            this.Firstname = fname;
            this.Surname = sname;

            Console.WriteLine("FullName is: " + this.Firstname + " " + this.Surname);
        }

        public void GetHeightDifference(int p1, int p2)
        {
            p1 = this.Height;
            int other = p2;

            int HeightDiff = p1 - other;
            if (HeightDiff < 0)
            {
                HeightDiff = -1 * HeightDiff;
            }
            Console.WriteLine(HeightDiff);

        }

        public void newSubject(Subject newsubject)
        {
            this.ListOfSubjects.Add(newsubject);
            Console.WriteLine();
            int len = this.ListOfSubjects.Count;
            for(int i=0; i<len; i++){
                Console.Write(this.ListOfSubjects[i].Name);
            }
        }

    }

    class Subject
    {
        public string Name;
        public int YearOfDelivery;


        public Subject(string name, int year)
        {
            this.Name = name;
            this.YearOfDelivery = year;
        }

    }

}
