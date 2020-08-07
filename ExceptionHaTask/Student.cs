using System;

namespace ExceptionHaTask
{
    public class Student
    {
        public string roomNumber;
        public string Name;
        public DateTime dateEntered;
        public DateTime TimeEntered;
        public int TimeInMin;
        public DateTime dateLeft;
        public DateTime TimeLeft;


        public Student()
        {
            this.roomNumber = "1as";
            this.Name = "ahlam";
            this.dateEntered = new DateTime();
            this.TimeEntered = DateTime.Parse("12:00");
            this.TimeInMin = 15;
            this.dateLeft = new DateTime();
            this.TimeLeft = DateTime.Parse("12:00");
        }

    }
}