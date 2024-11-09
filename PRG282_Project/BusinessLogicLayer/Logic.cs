using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;


// import namespaces
using PRG282_Project.DataAccessLayer;

namespace PRG282_Project.BusinessLogicLayer
{
    internal class Logic
    {
        FileHandler fh = new FileHandler(); // Object of the FileHandler class

        // Generate a new Student ID
        public string GenerateStudentID()
        {
            int studentId = fh.ReadStudentIDGen();
            studentId++; // Add 1 to the Student ID
            return studentId.ToString();
        }
        public void PassGeneratedStudentID()
        {
            fh.StoreLastStudentID(GenerateStudentID());
        }


        // Method to calculate for a summary report
        public (int, double) Calculate()
        {
            List<Student> students = fh.Read(); // Reads from the orignal list
            int totalAge = 0;

            // Loop through each student in the list and add up their ages
            foreach (Student student in students)
            {
                totalAge += student.Age;
            }

            int totalStudents = students.Count; // Counts total sstudents
            double averageAge = Math.Round((Convert.ToDouble(totalAge) / totalStudents), 2); // Calculates total average using total student and rounds answer to two decimal places

            if (averageAge.ToString() == "NaN")
            {
                averageAge = 0;
            }

            return (totalStudents, averageAge);
        }

        public void CalculateForTXT()
        {
            int totalStudents = 0;
            double averageAge = 0;
            (totalStudents, averageAge) = Calculate();
            // Pass calculated values to the GenerateSummary method for a TXT File
            fh.GenerateSummary(totalStudents, averageAge);
        }

        public void CalculateForPDF()
        {
            int totalStudents = 0;
            double averageAge = 0;
            (totalStudents, averageAge) = Calculate();
            // Pass calculated values to the GenerateSummary method for a PDF File
            fh.GeneratePDFSummary(totalStudents, averageAge);
        }
        public void DeleteStudent(string studentId)
        {
            // Reads from the orignal list
            List<Student> students = fh.Read();
            for (int i = students.Count - 1; i >= 0; i--)
            {
                if (students[i].StudentId == studentId)
                {
                    students.RemoveAt(i); // Removes student by index
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

            foreach (Student student in students)
            {
                dt.Rows.Add(student.StudentId, student.Name, student.Age, student.Course); // Add each student's data as a new row in the DataTable
            }

            return dt;
        }
        public void AddStudent(string studentId, string name, int age, string course)
        {
            List<Student> students = fh.Read(); // Reads from original list

            Student student = new Student(studentId, name, age, course);
            students.Add(student);// Adding a new Student to list

            fh.Write(students); // Passing updated student list to FileHandler
        }
        public void UpdateStudent(string studentId, string studentName, int age, string course)
        {
            List<Student> students = fh.Read();
            foreach (Student student in students)
            {
                if (student.StudentId == studentId)
                {
                    // Overriding student details if the student ID matches
                    student.Name = studentName;
                    student.Age = age;
                    student.Course = course;
                }
            }

            fh.Write(students); // Passing updated student list to FileHandler
        }

        // Search by Student ID
        public DataTable SearchStudentID(string studentId)
        {
            DataTable dt = new DataTable();
            List<Student> students = fh.Read(); // Reads from original list

            // Define columns for the DataTable
            dt.Columns.Add("StudentId");
            dt.Columns.Add("Name");
            dt.Columns.Add("Age");
            dt.Columns.Add("Course");
            foreach (Student student in students)
            {
                if (student.StudentId == studentId)
                {
                    dt.Rows.Add(student.StudentId, student.Name, student.Age, student.Course); // Adds a student's data as a new row in the DataTable
                    return dt; // Returns immediately after finding matching student ID
                }
            }
            MessageBox.Show($"Student ID '{studentId}' not found!");

            return dt;
        }

        // Search by Name
        public DataTable SearchStudentName(string name)
        {
            DataTable dt = new DataTable();
            List<Student> students = fh.Read(); // Reads from original list

            // Define columns for the DataTable
            dt.Columns.Add("StudentId");
            dt.Columns.Add("Name");
            dt.Columns.Add("Age");
            dt.Columns.Add("Course");

            bool nameFound = false;

            foreach (Student student in students)
            {
                if (student.Name.ToUpper() == name.ToUpper()) // converts values to Upper case letters (now it's Not Case Sensitive)
                {
                    nameFound = true;
                    dt.Rows.Add(student.StudentId, student.Name, student.Age, student.Course); // Adds each student's data as a new row in the DataTable
                }
            }
            if (!nameFound)
            {
                MessageBox.Show($"Name '{name}' not found!");
            }

            return dt;
        }


        // Search by Age
        public DataTable SearchStudentAge(int age)
        {
            DataTable dt = new DataTable();
            List<Student> students = fh.Read(); // Reads from original list

            // Define columns for the DataTable
            dt.Columns.Add("StudentId");
            dt.Columns.Add("Name");
            dt.Columns.Add("Age");
            dt.Columns.Add("Course");

            bool ageFound = false;

            foreach (Student student in students)
            {
                if (student.Age == age)
                {
                    ageFound = true;
                    dt.Rows.Add(student.StudentId, student.Name, student.Age, student.Course); // Adds each student's data as a new row in the DataTable
                }
            }
            if (!ageFound)
            {
                MessageBox.Show($"Age '{age}' not found!");
            }

            return dt;
        }

        // Search by Course
        public DataTable SearchStudentCourse(string course)
        {
            DataTable dt = new DataTable();
            List<Student> students = fh.Read(); // Reads from original list

            // Define columns for the DataTable
            dt.Columns.Add("StudentId");
            dt.Columns.Add("Name");
            dt.Columns.Add("Age");
            dt.Columns.Add("Course");

            bool courseFound = false;

            foreach (Student student in students)
            {
                if (student.Course.ToUpper() == course.ToUpper()) // converts values to Upper case letters (now it's Not Case Sensitive)
                {
                    courseFound = true;
                    dt.Rows.Add(student.StudentId, student.Name, student.Age, student.Course); // Adds each student's data as a new row in the DataTable
                }
            }

            if (!courseFound)
            {
                MessageBox.Show($"Course '{course}' not found!");
            }

            return dt;
        }



        // Input Validations
        string pattern = ""; // Declared pattern as a global variable
        public Boolean ValidID(string studentId)
        {
            pattern = @"^\d{6}$"; // Validates student IDs with 6 digit numbers (no letters or other special characters)

            Regex rg = new Regex(pattern);

            bool validID = rg.IsMatch(studentId); // Stores true if the Student Id is valid, else false

            if (validID)
            {
                return true;
            }
            return false;
        }

        public Boolean ValidName(string name)
        {
            pattern = @"^[a-zA-Z]{3,}$"; // Validates name with 3 minimum characters (letters only and no spaces or other characters)

            Regex rg = new Regex(pattern);

            bool validName = rg.IsMatch(name); // Stores true if the Name is valid, else false

            if (validName)
            {
                return true;
            }
            return false;
        }

        public Boolean ValidAge(int age)
        {
            pattern = @"^[1-9]\d$"; // Validates age between 10 and 99

            Regex rg = new Regex(pattern);

            bool validAge = rg.IsMatch(age.ToString()); // Stores true if the Age is valid, else false

            if (validAge)
            {
                return true;
            }
            return false;
        }

        public Boolean ValidCourse(string course)
        {
            pattern = @"^[a-zA-Z]{3,10}$"; // Validates course name between 3 to 10 characters (letters only and no spaces or other characters)

            Regex rg = new Regex(pattern);

            bool validCourse = rg.IsMatch(course); // Stores true if the Course name is valid, else false

            if (validCourse)
            {
                return true;
            }
            return false;
        }
    }
}