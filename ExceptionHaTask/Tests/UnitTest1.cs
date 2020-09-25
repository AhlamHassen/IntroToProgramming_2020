using System;
using Xunit;
using ExceptionHaTask;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void StudentConstructorTest()
        {
           Student s1 = new Student("1as", "aa", "9/11/2020", "12:00", 10, "9/11/2020", "14:00");

           Assert.True(true);

        }
        
         [Fact]
        public void timeDifferenceTest()
        {
           Student s1 = new Student("1as", "aa", "9/12/2020", "12:00", 10, "9/12/2020", "14:00");
           Menu m1 = new Menu();

           Assert.Equal(120, m1.timeDifference(s1.dateEntered, s1.TimeEntered, s1.dateLeft, s1.TimeLeft));
           
        }
    }
}
