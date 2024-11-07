using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PRG282_Project.DataAccessLayer
{
    internal class FileHandler
    {
        

        string path = @"students.txt";
        string summaryPath = @"summary.txt";
        public List<Student> Read()
        {
            List<Student> students = new List<Student>();
            if (File.Exists(path))
            {
                using(StreamReader sr = new StreamReader(path))
                {
                    string lines;
                    while ((lines = sr.ReadLine()) != null)
                    {
                        var templines = lines.Split(',').ToList();
                        Student student = new Student(templines[0], templines[1], int.Parse(templines[2]), templines[3]);
                        students.Add(student);
                    }
     
                }
                
            }
            else
            {
                Console.WriteLine("File not found!");
            }
            return students;

        }
        public void Write(List<Student> students)
        {

            using(StreamWriter sw = new StreamWriter(path))
            {
                foreach (Student student in students)
                {
                    sw.WriteLine($"{student.StudentId},{student.Name},{student.Age},{student.Course}");
                }
            }                    
            Console.WriteLine("Formatted and written to file");

        }

        public void GenerateSummary(int totalStudents, double averageAge)
        {
            using (StreamWriter sw = new StreamWriter(summaryPath))
            {
                sw.WriteLine($"Total Students: {totalStudents}\nAverage Age: {averageAge}");
            }
            Console.WriteLine("Summary Report written to file");
        }
    }
}
