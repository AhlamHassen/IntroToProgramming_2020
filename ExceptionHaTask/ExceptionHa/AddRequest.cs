using System;
using System.Text.Json.Serialization;

namespace ExceptionHaTask
{
    public class AddRequest
    {
        [JsonPropertyName("roomNumber")]
        public string roomNumber { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("dateEntered")]
        public string dateEntered { get; set; }

        [JsonPropertyName("TimeEntered")]
        public string TimeEntered { get; set; }

        [JsonPropertyName("TimeInMin")]
        public int TimeInMin { get; set; }

        [JsonPropertyName("dateLeft")]
        public string dateLeft { get; set; }

        [JsonPropertyName("TimeLeft")]
        public string TimeLeft { get; set; }


        public AddRequest()
        {
            this.roomNumber = "1as";
            this.Name = "ahlam";
            this.dateEntered = "9/14/2020";
            this.TimeEntered = "12:00";
            this.TimeInMin = 30;
            this.dateLeft = "9/14/2020";
            this.TimeLeft = "12:30";
        }

        public AddRequest(string roomNum, string name, string dateE, string timeE, int timeMin, string dateL, string timeL){
            this.roomNumber = roomNum;
            this.Name = name;
            this.dateEntered = dateE;
            this.TimeEntered = timeE;
            this.TimeInMin = timeMin;
            this.dateLeft = dateL;
            this.TimeLeft = timeL;
        }

    }
}