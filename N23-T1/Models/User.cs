namespace N23_T1.Models;

public class User
{
    public string EmailAddress { get; set; }
    public string Password { get; set; }

    public User(string emailAddress, string password)
    {
        EmailAddress = emailAddress;
        Password = password;
    }
}