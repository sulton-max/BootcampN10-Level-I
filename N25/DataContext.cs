namespace N25;

public class DataContext
{
    public List<User> Users { get; set; }
    public List<Talent> Talents { get; set; }
}

public class UserService
{
    private readonly DataContext _dataContext;

    public UserService(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public User CreateUser()
    {
        _dataContext.Users.Add()
    }
}