namespace ChallengeApp
{
    public class EmpolyeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";
        public EmpolyeeInFile(string name, string surname, int age)
            : base(name, surname, age)
        {
        }
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                    Console.WriteLine($"Ocena {grade} została zapisana do pliku {fileName}");
                }
            }
            else
            {
                throw new Exception("invalid grade value");
            }

        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char letter))
            {
                switch (letter)
                {
                    case 'A':
                    case 'a':
                        this.AddGrade(100);
                        break;
                    case 'B':
                    case 'b':
                        this.AddGrade(80);
                        break;
                    case 'C':
                    case 'c':
                        this.AddGrade(60);
                        break;
                    case 'D':
                    case 'd':
                        this.AddGrade(40);
                        break;
                    case 'E':
                    case 'e':
                        this.AddGrade(20);
                        break;
                    default:
                        throw new Exception("Wrong letter");


                }
            }
            else
            {
                throw new Exception("String is not float");
            }
        }
        public override void AddGrade(double grade)
        {
            {
                float gradeAsFloat = (float)grade;
                this.AddGrade(gradeAsFloat);
            }

        }
        public override void AddGrade(long grade)
        {
            {
                float gradeAsFloat = (float)grade;
                this.AddGrade(gradeAsFloat);
            }

        }
        public override void AddGrade(decimal grade)
        {
            {
                float gradeAsFloat = (float)grade;
                this.AddGrade(gradeAsFloat);
            }

        }
        public override void AddGrade(int grade)
        {
            {
                float gradeAsFloat = grade;
                this.AddGrade(gradeAsFloat);
            }

        }

        public override Statistics GetStatistic()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromFile);
            return result;
        }

        private List<float> ReadGradesFromFile()
        {

            var grades = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line is not null)
                    {
                        var grade = float.Parse(line);
                        grades.Add(grade);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }


        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;

            foreach (var grade in grades)
            {
                if (grade >= 0)
                {
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Average += grade;
                }

            }
            statistics.Average /= grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;


        }
        


    }
}
