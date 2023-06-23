using MoodAnalyserProblem;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        //TC1.1
        [TestMethod]
        [TestCategory("Sad Mood")]
        public void TestMethodAnalyzerForSadMood()
        {
            ///Arrange
            string message = "Im in sad mood";

            //Act
            MoodAnalyser analyser = new MoodAnalyser(message);
            string Actual = analyser.AnalyserMood();

            //Assert
            Assert.AreEqual(Actual, "sad");
        }
        //TC1.2
        [TestMethod]
        [TestCategory("In Any Mood")]
        public void TestMethodAnalayzerForAnyMood()
        {
            ///arrange
            string message = "Im in any mood";

            //Act
            MoodAnalyser analyser = new MoodAnalyser(message);
            string Actual = analyser.AnalyserMood();

            //Assert
            Assert.AreEqual(Actual, "happy");
        }
    }
}