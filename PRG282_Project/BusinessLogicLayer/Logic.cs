using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

// import namespaces
using PRG282_Project.DataAccessLayer;

namespace PRG282_Project.BusinessLogicLayer
{
    internal class Logic
    { 
        FileHandler fh = new FileHandler(); // Object of the FileHandler class

        // Method to calculate for a summary report
        public void Calculate()
        {
            
            List<Student> students = fh.Read(); // Reads from the orignal list
            int totalAge = 0;

            // Loop through each student in the list and add up their ages
            foreach (var student in students)
            {
                totalAge += student.Age;
            }

            int totalStudents = students.Count; // Counts total sstudents
            double averageAge = totalAge / totalStudents; // Calculates total average using total student

            // Pass calculated values to the GenerateSummary method
            fh.GenerateSummary(totalStudents, averageAge);
        }
        public void DeleteStudent(string studentId)
        {
            // Reads from the orignal list
            List<Student> students = fh.Read();

            foreach (var student in students)
            {
                if(student.StudentId == studentId) // Checks if student ID matches
                {
                    students.Remove(student); // Removes student from list if student ID matches
                }
            }

            fh.Write(students); // Passes the updated list to user
        }

        public DataTable DisplayStudents()
        { 
            DataTable dt = new DataTable(); // Creates new data table that will appear on data grid view
            List<Student> students = fh.Read(); // Reads from original list

            // Define columns for the DataTable
            dt.Columns.Add("StudentId");
            dt.Columns.Add("Name");
            dt.Columns.Add("Age");
            dt.Columns.Add("Course");

            foreach (var student in students)
            {
                dt.Rows.Add(student); // Add each student's data as a new row in the DataTable
            }

            return dt;
        }
    }
}
