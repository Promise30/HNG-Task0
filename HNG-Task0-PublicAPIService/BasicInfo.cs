namespace HNG_Task0_PublicAPIService
{
    public class BasicInfo
    {
        public string Email { get; set; }
        public string Time { get; set; } 
        public string GetCurrentIso8601Timestamp()
        {
            return DateTime.UtcNow.ToString("o");
        }
        public string GithubUrl { get; set; } = "";
    }
}
