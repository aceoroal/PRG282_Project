using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project.DataAccessLayer
{
    internal class Student
    {
        public string StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }


        public Student(string studentId, string name, int age, string course)
        {
            StudentId = studentId;
            Name = name;
            Age = age;
            Course = course;
        }
    }


}
