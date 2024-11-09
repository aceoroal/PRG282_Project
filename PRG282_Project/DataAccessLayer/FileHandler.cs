using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PRG282_Project.DataAccessLayer
{
    internal class FileHandler
    {
        // File paths
        string path = @"students.txt";
        string summaryPath = @"summary.txt";

        // Reading data from the student.txt file
        public List<Student> Read()
        {
            List<Student> students = new List<Student>();
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
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
                MessageBox.Show("File not found!");
            }

            return students;
        }

        // Updating the student.txt file by overriding it
        public void Write(List<Student> students)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (Student student in students)
                {
                    // Writing to the file
                    sw.WriteLine($"{student.StudentId},{student.Name},{student.Age},{student.Course}");
                }
            }
            MessageBox.Show("student.txt file was updated successfully, please check inside the bin folder");
        }

        public void GenerateSummary(int totalStudents, double averageAge)
        {
            using (StreamWriter sw = new StreamWriter(summaryPath))
            {
                // Writing the summary to the summary.txt file
                sw.WriteLine($"Total Students: {totalStudents}\nAverage Age: {averageAge}");
            }
            MessageBox.Show("Summary Report written to summary.txt file");
        }
    }
}