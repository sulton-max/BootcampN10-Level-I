using System.Text.RegularExpressions;
//Console.WriteLine(Validator.IsValidName(""));


public static class Validator
{
    public static void TestMethod()
    {
    }

    private const string _nameRegexPattern = null;

    public static bool IsValidName(string name) => Regex.IsMatch(name, _nameRegexPattern);

    static Validator()
    {
        Console.WriteLine("Static constructor is working");
        ValidateAllRegexPatterns();
    }

    public static void ValidateAllRegexPatterns()
    {
        var test = new Regex(_nameRegexPattern);

        //var fields = typeof(Validator).GetFields(System.Reflection.BindingFlags.Static);
        //var regex = null as Regex;
        //foreach (var field in fields)
        //{
        //    Console.WriteLine((string)field.GetValue(null));
        //    regex = new Regex((string)field.GetValue(null)!);
        //}
    }
}