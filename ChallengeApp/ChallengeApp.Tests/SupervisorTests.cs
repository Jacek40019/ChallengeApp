namespace ChallengeApp.Tests
{
    public class SupervisorTests
    {
        [Test]
        public void WhenGetStatisticColled_ShouldReturnCorrectMax()
        {
            // arrange
            var supervisor = new Supervisor("Lee", "Bao", 49);
            supervisor.AddGrade(79);
            supervisor.AddGrade(14);
            supervisor.AddGrade("6 -");

            // act
            var statistics = supervisor.GetStatistic();

            //assert
            Assert.AreEqual(95, statistics.Max);

        }

        [Test]
        public void WhenGetStatisticColled_ShouldReturnCorrectMin()
        {
            // arrange
            var supervisor = new Supervisor("Lee", "Bao", 49);
            supervisor.AddGrade("3");
            supervisor.AddGrade("- 3");
            supervisor.AddGrade("-3");
            supervisor.AddGrade("2+");


            // act
            var statistics = supervisor.GetStatistic();

            //assert
            Assert.AreEqual(25, statistics.Min);


        }

        [Test]
        public void WhenGetStatisticColled_ShouldReturnCorrectAverage()
        {
            // arrange
            var supervisor = new Supervisor("Lee", "Bao", 49);
            supervisor.AddGrade("+4");
            supervisor.AddGrade("+ 4");
            supervisor.AddGrade("4 +");
            supervisor.AddGrade("4+");

            // act
            var statistics = supervisor.GetStatistic();

            //assert
            Assert.AreEqual(65, statistics.Average);


        }
        [Test]
        public void WhenGetStatisticWithCharColled_ShouldReturnCorrectMax()
        {
            // arrange
            var supervisor = new Supervisor("Lee", "Bao", 49);
            supervisor.AddGrade("A");
            supervisor.AddGrade("b");
            supervisor.AddGrade("c");
            supervisor.AddGrade("D");
            supervisor.AddGrade("e");

            // act
            var statistics = supervisor.GetStatistic();

            //assert
            Assert.AreEqual(100, statistics.Max);


        }
        [Test]
        public void WhenGetStatisticWithCharColled_ShouldReturnCorrectMin()
        {
            // arrange
            var supervisor = new Supervisor("Lee", "Bao", 49);
            supervisor.AddGrade("A");
            supervisor.AddGrade("b");
            supervisor.AddGrade("c");
            supervisor.AddGrade("D");
            supervisor.AddGrade("e");

            // act
            var statistics = supervisor.GetStatistic();

            //assert
            Assert.AreEqual(20, statistics.Min);


        }

    }
}
