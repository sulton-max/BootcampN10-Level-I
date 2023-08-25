using System.Text.RegularExpressions;

namespace N32_T5;

public static class CustomValidator
{
    public static List<string> IsValidEmailAddress(string emailAddress)
    {
        var errorList = new List<string>();
        if (!string.IsNullOrWhiteSpace(emailAddress))
        {
            if (emailAddress.Length > 5)
            {
                if (Regex.IsMatch(emailAddress, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    return errorList;
                }
            }
            else
            {
                errorList.Add("Minimum length is 5");
            }
        }
        else
        {
            errorList.Add("Email address is required.");
        }

        return errorList;
    }
}