namespace N14.Encapsulation;

public class UniquePasswordGenerator
{
    public List<string> Passwords;

    public UniquePasswordGenerator()
    {
        Passwords = new List<string>();
    }

    internal string Generate()
    {
        var password = "password";

        //if (Passwords == null)
        //    Passwords = new List<string>();

        Passwords.Add(password);
        return password;
    }

    // tashqaridan ishlatilishi ta'qiqlangan method
    public void Clear()
    {
        Passwords = null;
    }

    public void Reset()
    {
        Clear();
        Passwords = new List<string>();
    }
}