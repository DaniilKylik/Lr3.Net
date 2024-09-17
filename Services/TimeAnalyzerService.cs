namespace Lr3.Net.Services
{
    public class TimeAnalyzerService
    {
        public string AnalyzeTime()
        {
            var currentTime = DateTime.Now;
            if (currentTime.Hour >= 12 && currentTime.Hour < 18)
                return "зараз день";
            if (currentTime.Hour >= 18 && currentTime.Hour < 24)
                return "зараз вечір";
            if (currentTime.Hour >= 0 && currentTime.Hour < 6)
                return "зараз ніч";
            return "зараз ранок";
        }
    }
}
