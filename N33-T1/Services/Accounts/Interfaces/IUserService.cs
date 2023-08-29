using System.Linq.Expressions;
using N33_T1.Models.Entities;

namespace N33_T1.Services.Accounts.Interfaces;

public interface IUserService
{
    IQueryable<User> Get(Expression<Func<User, bool>> expression);

    ValueTask<User?> GetByIdAsync (Guid id);

    ValueTask<User> CreateAsync(User user);

    ValueTask<User> UpdateAsync(User user);

    ValueTask<User> DeleteAsync(User user);

    ValueTask<User> DeleteByIdAsync(Guid userId);
}