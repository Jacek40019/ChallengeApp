using System.Xml.Linq;

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]

        public void TwoObjectsOfTheSameClassHaveDifferentReferences_ShouldBeNotEqual()
        {
            // arrange
            var employee1 = GetEmployee("Lee", "Wong", 27);
            var employee2 = GetEmployee("Lee", "Wong", 27);

            // act

            //assert
            Assert.AreNotEqual(employee1, employee2);

        }
       private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname,age);
        }

        [Test]

        public void TwoTheSameStringsFromDifferentObjects_ShouldBeEqual()
        {
            // arrange
            var employee1 = GetEmployee1("Lee", "Wong", 27);
            var employee2 = GetEmployee1("Lee", "Wong", 27);

            // act

            //assert
            Assert.AreEqual(employee1.Name, employee2.Name);

        }
        private Employee GetEmployee1(string  name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }

        [Test]

        public void TwoTheSameSrings_ShouldBeEqual()
        {
            // arrange
            string word1 = "telewizor";
            string word2 = "telewizor";


            // act

            //assert
            Assert.AreEqual(word1, word2);

        }

        [Test]

        public void TwoIntsOfDifferentValue_ShouldNotBeEqual()
        {
            // arrange
            int number1 = 1;
            int number2 = 7;

            // act

            //assert
            Assert.AreNotEqual(number1, number2);

        }


        [Test]

        public void TwoFloatsOfDifferentValue_ShouldNotBeEqual()
        {
            // arrange
            float number1 = 5.36F;
            float number2 = 3.16F;

            // act

            //assert
            Assert.AreNotEqual(number1, number2);

        }


    }
}

