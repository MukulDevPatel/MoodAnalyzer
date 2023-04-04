using MoodAnalyze;

namespace MoodAnalyzeTest
{
    public class Tests
    {
        [Test]
        public void GivenSadMood_WhenAnalyze_ShouldReturnSad()
        {
            string message = "I am in Sad Mood";
            MoodAnalyzer analyze = new MoodAnalyzer(message);
            string result = analyze.AnalyzeMood(message);
            Assert.AreEqual(result, "SAD");
        }
    }
}