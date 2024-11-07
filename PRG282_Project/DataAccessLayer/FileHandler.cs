using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project.DataAccessLayer
{
    internal class FileHandler
    {
        // Connection to file system

        // TODO:
        // 1. Writing and Reading text file (Create, Read, Update, Delete)
        // 2. Search students
        // 3. Generate summary (from the logic layer)

         public void write(List<Student> plist)
        {

            

            List<string> output = new List<string>();
            foreach (Student person in plist)
            {
                output.Add(person.ToString());
            }
            File.WriteAllLines(path, output);
            Console.WriteLine("Formatted and written to file");

        }

        

        public List<string> read()
        {
            List<string> list = new List<string>();
            if (File.Exists(path))
            {
                
                list = File.ReadAllLines(path).ToList();

                Console.WriteLine("Original Data:");
                Console.WriteLine("======================");

                foreach (string line in list)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine("=========================");
            }
            
            return list;
        }
    }
}
