using System.Text;

namespace N14.OverridingExample;

public class PasswordGenerator
{
    public readonly int length;
    public readonly bool hasLetters;
    public readonly bool hasDigits;

    public PasswordGenerator(int length, bool hasLetters, bool hasDigits = false)
    {
        if (length < 4 || (hasLetters == false && hasDigits == false))
            throw new ArgumentException();

        this.length = length;
        this.hasLetters = hasLetters;
        this.hasDigits = hasDigits;
    }

    // a - z - 97 - 122
    // A - Z - 65 - 90
    public virtual string Generate()
    {
        var random = new Random();
        var password = new StringBuilder();

        for (var index = 0; index < length;)
        {
            if (hasDigits && random.Next(0, 2) == 0)
            {
                var randomDigit = random.Next(0, 10);
                password.Append(randomDigit);

                index++;
            }
            else if (hasLetters)
            {
                var randomChar = random.Next(0, 1) == 0
                    ? (char)random.Next(97, 123)
                    : (char)random.Next(65, 91);

                index++;

                password.Append(randomChar);
            }
        }

        return password.ToString();
    }
}