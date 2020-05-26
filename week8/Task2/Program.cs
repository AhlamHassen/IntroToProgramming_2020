using System;
using System.Collections.Generic;

namespace tt
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Ahlam", "Hassen", 1997, 155);
            Person p2 = new Person("Amiiy", "Saleh", 1999, 160);
            Person p3 = new Person("Alam", "Adem", 1999, 170);
            
            Console.WriteLine("Person 1");
            Console.Write("Full Name: "); p1.GetFulllName();
            Console.Write("Height difference from person2: ");
            p1.GetHeightDifference(p1.Height, p2.Height);
            Console.Write("Height difference from person3: ");
            p1.GetHeightDifference(p1.Height, p3.Height);
            Console.WriteLine();

            Console.WriteLine("Person 2");
            Console.Write("Full Name: "); p2.GetFulllName();
            Console.Write("Height difference from person1: ");
            p1.GetHeightDifference(p2.Height, p1.Height);
            Console.Write("Height difference from person3: ");
            p1.GetHeightDifference(p2.Height, p3.Height);
            Console.WriteLine();

            Console.WriteLine("Person 3");
            Console.Write("Full Name: "); p3.GetFulllName();
            Console.Write("Height difference from person1: ");
            p1.GetHeightDifference(p3.Height, p1.Height);
            Console.Write("Height difference from person2: ");
            p1.GetHeightDifference(p3.Height, p2.Height);
            Console.WriteLine();

            Random ran1 = new Random();
            int Ran1 = ran1.Next(1000,10000);

            Random ran2 = new Random();
            int Ran2 = ran2.Next(1000,10000);

            Random ran3 = new Random();
            int Ran3 = ran3.Next(1000,10000);

            p1.ID = Ran1;
            p2.ID = Ran2;
            p3.ID = Ran3;

            Console.WriteLine("The ID of Person 1 is: " + p1.ID);
            Console.WriteLine("The ID of Person 2 is: " + p2.ID);
            Console.WriteLine("The ID of Person 3 is: " + p3.ID);
            Console.WriteLine();

            Subject English = new Subject("English", 2020);
            Subject Math = new Subject("Math", 2020);
            Subject Chemistry = new Subject("Chemistry", 2020);

            p1.AddnewSubject(English);
            p1.AddnewSubject(Math);
            p1.AddnewSubject(Chemistry);

            p1.AllocateGrade(1,98);
            p1.AllocateGrade(0,100);
            

        }
    }

    class Person
    {
        public string Firstname;
        public string Surname;
        public int Dob;
        public int Height;
        public int ID;
        public List<Subject> subjectList;
    
        
        
        public Person(string fname, string sname, int Db, int height){
           this.Firstname =  fname;
           this.Surname = sname;
           this.Dob = Db;
           this.Height = height;
           this.ID = 0;
           this.subjectList = new List<Subject>();
        }

        public void GetFulllName(){
           string fname = this.Firstname + " " + this.Surname ;
            Console.WriteLine(fname);
        }

        public void GetHeightDifference(int p1, int p2){
          int p = p1;
          int other = p2;

          int result = p1 - p2;
          if (result < 0){
             result = result * -1 ;
          }
          Console.WriteLine(result);
        }

        public void AddnewSubject(Subject newS){
           this.subjectList.Add(newS);
           int len = this.subjectList.Count;
           string sub =" ";
           for(int i=0; i<len; i++){
               sub =subjectList[i].Name;
           }
           Console.WriteLine(sub);
        }

        public void AllocateGrade(int sub, int grade){
           Console.Write("Grade for Subject: " + this.subjectList[sub].Name + " is ");
           Console.WriteLine (this.subjectList[sub].Grade = grade);
        }

    }

    class Subject
    {
       public string Name;
        public int yearOfDelivery;
        public int Grade;
        
        public Subject(string nm, int year){
            this.Name = nm;
            this.yearOfDelivery = year;
            
        }
    }
}
