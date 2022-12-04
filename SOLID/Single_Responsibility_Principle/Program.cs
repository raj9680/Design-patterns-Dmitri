using System;
using System.Collections.Generic;
using System.IO;

namespace Single_Responsibility_Principle // Each class should responsible for Single Responsibility
{
    public class Journal
    {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count;
        }
        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }
        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

        /// Creating Journal File - X
        /*
        public void Save(string filename)
        {
            File.WriteAllText(filename, ToString());
        }
        */
    }

    // Separate class for Creating Journal File
    public class Persistence
    {
        public void SaveToFile(Journal j, string filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(filename))
                File.WriteAllText(filename, j.ToString());
        }
    }


    
    
    // Mains
    class Program
    {
        static void Main(string[] args)
        {
            var j = new Journal();
            j.AddEntry("I cried today");
            j.AddEntry("I ate a bug");
            Console.WriteLine(j);

            var p = new Persistence();
            var filename = @"C:\Users\raj.kumar\Desktop\journal.txt";
            p.SaveToFile(j, filename, true);

            
            // For more

            /*
            
            Employee employeeService = new Employee
            {
                FirstName = "John",
                LastName = "Deo"
            };

            var EmployeeService = new EmployeeService();
            EmployeeService.EmployeeRegistration(employeeService);
            Console.ReadKey();

            */
        }

// Conclusion
/*
         
    Conslusion: Single Responsibility Pronciple states that, a typical class is responsible for one thing
    and has one reason to change.
         
*/
    }
}
