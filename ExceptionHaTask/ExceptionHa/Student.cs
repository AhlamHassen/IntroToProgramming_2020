using System;
using System.Text.Json.Serialization;

namespace ExceptionHaTask
{
    public class Student
    {
        [JsonPropertyName("roomNumber")]
        public string roomNumber { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("dateEntered")]
        public DateTime dateEntered { get; set; }

        [JsonPropertyName("TimeEntered")]
        public DateTime TimeEntered { get; set; }

        [JsonPropertyName("TimeInMin")]
        public int TimeInMin { get; set; }

        [JsonPropertyName("dateLeft")]
        public DateTime dateLeft { get; set; }

        [JsonPropertyName("TimeLeft")]
        public DateTime TimeLeft { get; set; }


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

        public Student(string roomNum, string name, string dateE, string timeE, int timeMin, string dateL, string timeL){
            this.roomNumber = roomNum;
            this.Name = name;
            this.dateEntered = DateTime.Parse(dateE);
            this.TimeEntered = DateTime.Parse(timeE);
            this.TimeInMin = timeMin;
            this.dateLeft = DateTime.Parse(dateL);
            this.TimeLeft = DateTime.Parse(timeL);
        }

    }
}