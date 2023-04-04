namespace MoodAnalyze
{
    public class MoodAnalyzer
    {
        private string message; //UC2
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood(string message)
        {
            if (message.Contains("sad"))
                return "SAD";
            else
                return "HAPPY";
        }
    }
}