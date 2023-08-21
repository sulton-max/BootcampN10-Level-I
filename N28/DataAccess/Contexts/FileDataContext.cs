using N28.Models.Entities;

namespace N28.DataAccess.Contexts;

public class FileDataContext
{
    public FileSet<User> Users { get; init; } = new(nameof(Users));
    public FileSet<BlogPost> Posts { get; init; } = new(nameof(Posts));

    public FileDataContext()
    {
        Initialize();
    }

    public void Initialize()
    {
        Posts.Initialize();
        Users.Initialize();
    }

    public void SaveChanges()
    {
        Posts.SaveChanges();
        Users.SaveChanges();
    }
}