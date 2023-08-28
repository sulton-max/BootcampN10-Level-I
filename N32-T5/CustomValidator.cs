using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace N32_T5;

public static class CustomValidator
{
    public static string? IsValidEmailAddress(string? emailAddress)
    {
        if (!string.IsNullOrWhiteSpace(emailAddress))
        {
            if (emailAddress.Length > 5)
            {
                if (Regex.IsMatch(emailAddress, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    return null;
                }
            }
            else
            {
                return "Minimum length is 5";
            }
        }
        else
        {
            return "Email address is required.";
        }

        return null;
    }
}