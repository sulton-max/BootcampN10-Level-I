using System.Text;

namespace N14.OverridingExample;

public class SecurePasswordGenerator : PasswordGenerator
{
    private readonly bool hasSymbols;

    public SecurePasswordGenerator(int length, bool hasLetters, bool hasSymbols, bool hasDigits = false)
        : base(length, hasLetters, hasDigits)
    {
        this.hasSymbols = hasSymbols;
    }

    public override string Generate()
    {
        var random = new Random();
        var password = new StringBuilder();

        for (var index = 0; index < length;)
        {
            var randomChoice = random.Next(0, 3);

            if (hasDigits && randomChoice == 0)
            {
                var randomDigit = random.Next(0, 10);
                index++;

                password.Append(randomDigit);
            }
            else if (hasLetters && randomChoice == 1)
            {
                var randomChar = random.Next(0, 1) == 0
                    ? (char)random.Next(97, 123)
                    : (char)random.Next(65, 91);
                password.Append(randomChar);

                index++;

            }
            else if (hasSymbols && randomChoice == 2)
            {
                var randomSymbol = (char)random.Next(33, 48);
                password.Append(randomSymbol);

                index++;

            }
        }

        return password.ToString();
    }
}