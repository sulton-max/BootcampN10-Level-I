using N33_T1.DataAccess.Configurations;
using N33_T1.DataAccess.FileContext;
using N33_T1.Models.Entities;

namespace N33_T1.DataAccess;

public class AppFileContext : DataContext.FileContext
{
    public AppFileContext(FileContextOptions options) : base(options)
    {
    }

    public FileSet<User> Users = new FileSet<User>();
}