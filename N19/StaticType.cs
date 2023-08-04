using System.Text.RegularExpressions;
using N19;

public static class StaticType
{
    public static int Sum(in List<int> values)
    {
        //values = new List<int>(); // invalid
        return values.Sum();
    }

    public static string ToMessage(string template)
    {
        template = template.Replace("{{User}}", "G`ishtmat");
        return template;
    }

    #region In parameter

    public static int Sum(in int[] array)
    {
        //array = new int[0]; // invalid 

        var sum = 0;
        foreach (var item in array)
            sum += item;
        
        return sum;
    }

    public static void Calculate(in int value)
    {
        // Calcuation 1
        //value = 10; invalid

        // Calcuation 2

        //value

        // Calcuation 3
    }

    #endregion

    #region Out parameter

    public static bool IsValidEmailAddress(in string emailAddress, out string formattedEmailAddress)
    {
        formattedEmailAddress = string.Empty;

        if (string.IsNullOrWhiteSpace(emailAddress))
            return false;

        formattedEmailAddress = emailAddress.Trim();
        if (Regex.IsMatch(formattedEmailAddress, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            return true;

        return false;
    }

    #endregion

    #region Ref parameter

    public static bool WithdrawMoney(ref int balance, int amount)
    {
        if (balance < amount)
            return false;

        balance -= amount;
        return true;
    }

    public static void ToMessageB(ref string template)
    {
        template = template.Replace("{{User}}", "G`ishtmat");
    }

    // O'zgarmaydi - chunki original reference ni yo'qotib qo'ydik
    public static void ChangeArrA(int[] array)
    {
        array = new int[0];
    }

    // O'zgarmaydi - chunki original reference ni yo'qotib qo'ydik
    public static void ChangeStringa(string value)
    {
        value = "";
    }

    // O'zgaradi - chunki original reference bo'yicha o'zgartiryapmiz
    public static void ChangeArrB(int[] array)
    {
        array[0] = 10;
    }

    // O'zgarmaydi - immutable bo'lgani uchun
    public static void ChangeStringB(string value)
    {
        value.Concat("");
    }

    #endregion

    #region Params

    // Eski usul
    //public static int CalculatePrice(Drink drink)
    //{
    //    return drink.Price;
    //}

    // public static int CalculatePrice(Drink drinkA, Drink drinkB)
    // {
    //     return drinkA.Price + drinkB.Price;
    // }

    //public static int CalculatePrice(Drink[] drinks)
    //{
    //    var sum = 0;
    //    foreach (Drink drink in drinks)
    //    {
    //        sum += drink.Price;
    //    }

    //    return sum;
    //}

    public static int CalculatePrice(params Drink[] drinks)
    {
        var sum = 0;
        foreach (Drink drink in drinks)
        {
            sum += drink.Price;
        }

        return sum;
    }

    #endregion

    #region Optional

    public static double CalculateCredit(double principal, int months, int interest = 10)
    {
        //Principal* Interest Rate* Loan Term

        return (principal + principal * interest / 100) / months;
    }

    #endregion

    #region Named

    #endregion
}