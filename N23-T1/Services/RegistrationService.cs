using N23_T1.Models;

namespace N23_T1.Services;

public class RegistrationService
{
    private readonly List<User> _users = new();

    public bool Register(string emailAddress, string password)
    {
        if (_users.Any(x => x.EmailAddress == emailAddress))
        {
            Console.WriteLine("bu email bor");
            return false;
        }

        _users.Add(new User(emailAddress, password));
        return true;
    }
}