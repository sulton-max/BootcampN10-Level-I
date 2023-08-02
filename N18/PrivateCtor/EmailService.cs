using System.Runtime.InteropServices;

namespace N18.PrivateCtor
{
    public static class RandomExtensions
    {
        public static string ToUrl(this string str) =>
            !string.IsNullOrWhiteSpace(str) ? str.Replace("\\", "/") : str;

        public static string ToPath(this string str) =>
             !string.IsNullOrWhiteSpace(str) ? str.Replace("/", "\\") : str;
    }

    public class EmailService
    {
        private static EmailService _instance;

        private EmailService()
        {
        }

        public static EmailService GetInstance()
        {
            if (_instance is null)
                _instance = new EmailService();

            return _instance;
        }

        public static bool IsValidEmailAddress(string emailAddress)
        {
            return true;
        }
    }
}
