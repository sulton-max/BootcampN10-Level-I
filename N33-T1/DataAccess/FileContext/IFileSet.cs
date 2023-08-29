using N33_T1.DataAccess.EntityContext;

namespace N33_T1.DataAccess.FileContext;

public interface IFileSet<TEntity>  where TEntity : class, IUpdatableEntity<TEntity>
{
     bool IsModified { get; }

     Task FetchDataAsync();

     Task<int> SaveChangesAsync();
}