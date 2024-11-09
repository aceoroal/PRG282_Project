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
        string studentIDPath = @"studentID_last_generated.txt";
        string summaryPath = @"summary.txt";
        string pdfPath = @"summary.pdf";

        // Reading data from the student.txt file
        public List<Student> Read()
        {
            List<Student> students = new List<Student>();
            if (!File.Exists(path)) // If the file doen't exist
            {
                File.Create(path).Close();
            }

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
            return students;
        }

        public int ReadStudentIDGen()
        {
            int studentIdGen;
            if (!File.Exists(studentIDPath))
            {
                File.Create(studentIDPath).Close();
                // Store 602000
                using (StreamWriter swRID = new StreamWriter(studentIDPath))
                {
                    swRID.Write($"602000");
                }
            }
            string line;
            using (StreamReader srID = new StreamReader(studentIDPath))
            {
                line = srID.ReadLine();
            }
            studentIdGen = int.Parse(line);
            return studentIdGen;
        }
        // Store the last generated Student ID
        public void StoreLastStudentID(string studentId)
        {
            if (!File.Exists(studentIDPath))
            {
                File.Create(studentIDPath).Close();
            }

            using (StreamWriter swSID = new StreamWriter(studentIDPath))
            {
                swSID.Write($"{studentId}");
            }
        }

        // Updating the student.txt file by overriding it
        public void Write(List<Student> students)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }

            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (Student student in students)
                {
                    // Writing to the file
                    sw.WriteLine($"{student.StudentId},{student.Name},{student.Age},{student.Course}");
                }
            }
        }

        public void GenerateSummary(int totalStudents, double averageAge)
        {
            if (!File.Exists(summaryPath))
            {
                File.Create(summaryPath).Close();
            }

            using (StreamWriter swS = new StreamWriter(summaryPath))
            {
                // Writing the summary to the summary.txt file
                swS.WriteLine($"Total Students: {totalStudents}\nAverage Age: {averageAge}");
            }
        }

        // Generates a Summary Report in a PDF format
        public void GeneratePDFSummary(int totalStudents, double averageAge)
        {
            string html = $@"<!DOCTYPE html>
<html lang='en'>
<head>
    <meta charset='UTF-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <title>Document</title>
</head>
<body style='margin: 0;padding: 0;'>
    <table>
        <tr>
            <td>
                <img src='https://i.ibb.co/hsBzNV2/bg-1.png' style='margin-left: -40px;width: 580px;height: 265px;' alt='bg-1' border='0'>
                <p style='color: #555555;font-size: 16.2px;margin-left: 35px;'>Date: {DateTime.Now.Date.ToString().Substring(0, 10)}</p>
                <div></div>
                <p style='font-weight: 600;font-size: 19px;margin-left: 35px;'>Total Students: {totalStudents}</p>
                <p style='font-weight: 600;font-size: 19px;margin-left: 35px;'>Average Age: {averageAge}</p>
                <img src='https://i.ibb.co/71CKqJf/bg-2.png' style='margin-left: -40px;width: 580px;height: 370px;' alt='bg-2' border='0'>
            </td>
        </tr>
    </table>
</body>
</html>";

            var pdfBytes = PdfSharpConvert(html);

            // Write to a PDF file
            if (!File.Exists(pdfPath))
            {
                File.Create(pdfPath).Close();
            }

            File.WriteAllBytes(pdfPath, pdfBytes);
        }
        public static Byte[] PdfSharpConvert(String html)
        {
            Byte[] res = null;
            using (MemoryStream ms = new MemoryStream())
            {
                var pdf = TheArtOfDev.HtmlRenderer.PdfSharp.PdfGenerator.GeneratePdf(html, PdfSharp.PageSize.A4);
                pdf.Save(ms);
                res = ms.ToArray();
            }
            return res;
        }
    }
}
