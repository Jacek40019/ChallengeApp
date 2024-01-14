

using System.IO.Enumeration;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace FarmEmployees
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string suffixFilename = "_FARMemployee.txt";

        private string name;
        private string surname;
        private string filename;
       
        public override string Name
        {
            get
            {
                return $"{char.ToUpper(name[0])}{name.Substring(1, name.Length - 1).ToLower()}";
            }
            set
            {
                name = value;
            }
        }

        public override string Surname
        {
            get
            {
                return $"{char.ToUpper(surname[0])}{surname.Substring(1, surname.Length - 1).ToLower()}";
            }
            set
            {
                surname = value;
            }
        }

        public EmployeeInFile(string name, string surname)
               : base(name, surname)
        {
            filename = $"{name}_{surname}{suffixFilename}";
        }

       
        public override void AddSalary(float salaryForFruit)
        {
            using (var writer = File.AppendText(filename))
            {
                writer.WriteLine(salaryForFruit);
            }
        }

        public override Statistics GetStatistics()
        {
            
            var data = new DataForCalculateion(); 
            var statistics = new Statistics(data); 
            
            if (File.Exists($"{filename}"))
            {
                using (var reader = new StreamReader($"{filename}"))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var value = float.Parse(line);
                        statistics.AddSalary(value);
                        
                    }
                }           
            } 
            return statistics;

        }
    }
}
