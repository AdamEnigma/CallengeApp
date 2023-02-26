
namespace ChallengeApp.Test
{
    public class Tests
    {

        [Test]
        public void WenEmployeeCollectTwoScore_ShouldCorrectResult()
        {
            // arrange - przygotowanie

            var user = new Employee("Adam", "Kami�ski", 30);
            user.AddScore(2);
            user.AddScore(-2);
            user.AddScore(2);

            // act - uruchomienie

            var result = user.Result;

            //assert - sprawdzenie czy zosta�y spe�nione warunki

            Assert.AreEqual(2, result);
        }

        [Test]
        public void WenEmployeeCollectTwoScore_ShouldCorrectResult1()
        {
            // arrange - przygotowanie

            var user = new Employee("Adam", "Kami�ski", 30);
            user.AddScore(2);
            user.AddScore(2);
            user.AddScore(2);

            // act - uruchomienie

            var result = user.Result;

            //assert - sprawdzenie czy zosta�y spe�nione warunki

            Assert.AreEqual(6, result);
        }
    }
}