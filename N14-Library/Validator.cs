using System.Text.RegularExpressions;

namespace Library
{
    public class Validator
    {
        internal protected Regex EmailAddressRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        
        private protected Regex FirstNameRegex = new Regex("");

        public void ValidateFirstName(string emailAddress)
        {

        }

        public void ValidateLastName(string emailAddress)
        {

        }

        public void ValidateEmailAddress(string emailAddress)
        {

        }


    }
}