using System.Text.RegularExpressions;
using Library;

public class SuperValidator : Validator
{
    // internal or protected
    public SuperValidator()
    {
        EmailAddressRegex = new Regex("678"); // tezroq ishlaydigan regex

        // private protected
        //FirstNameRegex = new Regex("678");
    }
}