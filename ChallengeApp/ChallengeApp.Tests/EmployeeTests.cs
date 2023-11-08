namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectJustPositiveScores_ShouldReturnCorrectSumAsResult()
        {
            // arrange
            // varables: name (string), surname (string), age (int)
            var employee = new Employee("Franek", "Kimono", 37);
            employee.Addscores(5);
            employee.Addscores(6);
            employee.Addscores(9);
            employee.Addscores(2);

            // act
            var result = employee.Result;

            //assert
            Assert.AreEqual(22, result);


        }

        [Test]
        public void WhenEmployeeCollectPositiveAndNegativeScores_ShouldReturnCorrectSumAsResult()
        {
            // arrange
            // varables: name (string), surname (string), age (int)
            var employee = new Employee("Franek", "Kimono", 37);
            employee.Addscores(1);
            employee.Addscores(-2);
            employee.Addscores(8);
            employee.Addscores(-6);

            // act
            var result = employee.Result;

            //assert
            Assert.AreEqual(1, result);


        }
        [Test]
        public void WhenEmployeeCollectJustNegativeScores_ShouldReturnCorrectSumAsResult()
        {
            // arrange
            // varables: name (string), surname (string), age (int)
            var employee = new Employee("Franek", "Kimono", 37);
            employee.Addscores(-9);
            employee.Addscores(-2);
            employee.Addscores(-1);

            // act
            var result = employee.Result;

            //assert
            Assert.AreEqual(-12, result);


        }
    }
}
