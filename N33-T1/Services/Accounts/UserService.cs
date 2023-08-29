using System.Linq.Expressions;
using N33_T1.DataAccess;
using N33_T1.DataAccess.DataContext;
using N33_T1.Extensions;
using N33_T1.Models.Entities;
using N33_T1.Services.Accounts.Interfaces;

namespace N33_T1.Services.Accounts;

public class UserService : IUserService
{
    private readonly AppFileContext _fileContext;

    public UserService(AppFileContext fileContext)
    {
        _fileContext = fileContext;
    }

    public IQueryable<User> Get(Expression<Func<User, bool>> expression)
    {
        return _fileContext.Users.Where(expression.Compile()).AsQueryable();
    }

    public ValueTask<User?> GetByIdAsync(Guid id)
    {
        var user = _fileContext.Users.FirstOrDefault(user => user.Id == id);
        return new ValueTask<User?>(Task.FromResult(user));
    }

    public async ValueTask<User> CreateAsync(User user)
    {
        // var validationResult = _validationService.ValidateUserOnCreate(user);
        // if (validationResult.IsValid)
        //     throw new validationResult.Exception;

        _fileContext.Users.Add(user);
        await _fileContext.SaveChangesAsync();

        return user;
    }

    public async ValueTask<User> UpdateAsync(User user)
    {
        var foundUser = await GetByIdAsync(user.Id)
                        ?? throw new InvalidOperationException("User not found");

        foundUser.UserName = user.UserName;
        await _fileContext.SaveChangesAsync();

        return user;
    }

    public async ValueTask<User> DeleteAsync(User user)
    {
        var foundUser = await GetByIdAsync(user.Id)
                        ?? throw new InvalidOperationException("User not found");

        _fileContext.Users.Remove(foundUser);
        await _fileContext.SaveChangesAsync();

        return user;
    }

    public async ValueTask<User> DeleteByIdAsync(Guid userId)
    {
        var foundUser = await GetByIdAsync(userId)
                        ?? throw new InvalidOperationException("User not found");

        _fileContext.Users.Remove(foundUser);
        await _fileContext.SaveChangesAsync();

        return foundUser;
    }
}