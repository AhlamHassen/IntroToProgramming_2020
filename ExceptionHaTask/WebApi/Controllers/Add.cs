using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ExceptionHaTask;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddController : ControllerBase
    {
        static List<Student> Students = new List<Student>();

        public AddController()
        {
            Students.Add(new Student());
        }

        [HttpPost("Add")]
        public string addStudent([FromBody] AddRequest req)
        { 
            Students.Add(new Student(req.roomNumber, req.Name, req.dateEntered,
                 req.TimeEntered, req.TimeInMin, req.dateLeft, req.TimeLeft ));
            return "Student Added";

        }

        [HttpGet("{name}")]
        public Student findStudent(string name)
        {
            Student found = null;
            foreach (Student s in Students)
            {
                if (s.Name == name)
                {
                    found = s;
                    break;
                }
            }

            return found;
        }

        [HttpGet("GetAll")]
        public List<Student> getAll()
        {
            return Students;
        }

        [HttpPost("Find")]
        public Student FindPerson ([FromBody] Student student){
           Student found = null;
           foreach (Student s in Students)
            {
                if (s.Name == student.Name)
                {
                    found = s;
                    break;
                }
            }
            return found;
            
        }

    }
}
