namespace MoodAnalyzer
{
    public class MoodAnalyzer
    {
        private string message; //UC1
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood()
        {
            if (message.Contains("sad"))
                return "SAD";
            else
                return "HAPPY";
        }
    }
}