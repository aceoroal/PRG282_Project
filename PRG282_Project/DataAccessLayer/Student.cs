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
        public double Mark { get; set; }


        public Student(string studentId, string name, int age, double mark)
        {
            StudentId = studentId;
            Name = name;
            Age = age;
            Mark = mark;
        }
    }


}
