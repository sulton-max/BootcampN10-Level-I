namespace N28.Models.Common;

public interface IUpdatableEntity<TEntity> where TEntity : class, IEntity
{
    void Update(TEntity model);
}