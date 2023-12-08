namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenGetStatisticColled_ShouldReturnCorrectMax()
        {
            // arrange
            var employee = new EmployeeInMemory("Lee", "Wong", 27);
            employee.AddGrade(5);
            employee.AddGrade(1);
            employee.AddGrade(9);

            // act
            var statistics = employee.GetStatistic();

            //assert
            Assert.AreEqual(9, statistics.Max);

        }

        [Test]
        public void WhenGetStatisticColled_ShouldReturnCorrectMin()
        {
            // arrange
            var employee = new EmployeeInMemory("Lee", "Wong", 27);
            employee.AddGrade(5);
            employee.AddGrade(1);
            employee.AddGrade(9);


            // act
            var statistics = employee.GetStatistic();

            //assert
            Assert.AreEqual(1, statistics.Min);


        }

        [Test]
        public void WhenGetStatisticColled_ShouldReturnCorrectAverage()
        {
            // arrange
            var employee = new EmployeeInMemory("Lee", "Wong", 27);
            employee.AddGrade(17);
            employee.AddGrade(83);
            employee.AddGrade(80);
            employee.AddGrade("e");
           

            // act
            var statistics = employee.GetStatistic();

            //assert
            Assert.AreEqual(50, statistics.Average);


        }
        [Test]
        public void WhenGetStatisticWithCharColled_ShouldReturnCorrectMax()
        {
            // arrange
            var employee = new EmployeeInMemory("Lee", "Wong", 27);
            employee.AddGrade("A");
            employee.AddGrade("b");
            employee.AddGrade("c");
            employee.AddGrade("D");
            employee.AddGrade("e");
            
            // act
            var statistics = employee.GetStatistic();

            //assert
            Assert.AreEqual(100, statistics.Max);


        }
        [Test]
        public void WhenGetStatisticWithCharColled_ShouldReturnCorrectMin()
        {
            // arrange
            var employee = new EmployeeInMemory("Lee", "Wong", 27);
            employee.AddGrade("A");
            employee.AddGrade("b");
            employee.AddGrade("c");
            employee.AddGrade("D");
            employee.AddGrade("e");
          
            // act
            var statistics = employee.GetStatistic();

            //assert
            Assert.AreEqual(20, statistics.Min);


        }

    }
}