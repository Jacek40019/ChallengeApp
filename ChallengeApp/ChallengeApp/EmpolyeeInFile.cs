namespace ChallengeApp
{
    public class EmpolyeeInFile : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

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

                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }

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
            var statistics = new Statistics();

            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line is not null)
                    {
                        var grade = float.Parse(line);
                        statistics.AddGrade(grade);
                        line = reader.ReadLine();
                    }
                }
            }
            return statistics;
        }
    }
}
