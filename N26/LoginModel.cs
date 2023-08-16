using System.Text.RegularExpressions;

public class LoginModel
{
    private Dictionary<string, string> _errorsList = new();

    private string _emailAddress;
    private string _password;

    public LoginModel(string emailAddress, string password)
    {
        EmailAddress = emailAddress;
        Password = password;
    }

    public string EmailAddress
    {
        get => _emailAddress;
        set
        {
            if (!Regex.IsMatch(value, "^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\\.[a-zA-Z0-9]+$"))
            {
                _errorsList[nameof(EmailAddress)] = "Email address is invalid";
                return;
            }

            _emailAddress = value;
            _errorsList.Remove(nameof(EmailAddress));
        }
    }

    public string Password
    {
        get => _password;
        set
        {
            if (!Regex.IsMatch(value, @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$"))
            {
                _errorsList[nameof(Password)] = "Password is invalid";
                return;
            }

            _password = value;
            _errorsList.Remove(nameof(Password));
        }
    }

    public static bool operator true(LoginModel loginModel)
    {
        return loginModel.GetErrors().Count == 0;
    }

    public static bool operator false(LoginModel loginModel)
    {
        return loginModel.GetErrors().Count > 0;
    }

    public static bool operator !(LoginModel loginModel)
    {
        return loginModel ? false : true;
    }

    public List<string> GetErrors()
    {
        return _errorsList.Values.ToList();
    }
}