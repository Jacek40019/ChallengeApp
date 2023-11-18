namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenGetStatisticColled_ShouldReturnCorrectMax()
        {
            // arrange
            var employee = new Employee("Lee", "Wong");
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
            var employee = new Employee("Lee", "Wong");
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
            var employee = new Employee("Lee", "Wong");
            employee.AddGrade(5);
            employee.AddGrade(1);
            employee.AddGrade(9);


            // act
            var statistics = employee.GetStatistic();

            //assert
            Assert.AreEqual((5 + 1 + 9) / 3, statistics.Average);


        }
    }
}