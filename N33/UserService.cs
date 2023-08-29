namespace N33;

public static class UserService
{
    private static List<User> _users = new();



    public static IEnumerable<User> GetUsers() => _users;
}