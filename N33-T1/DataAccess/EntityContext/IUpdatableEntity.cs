namespace N33_T1.DataAccess.EntityContext;

public interface IUpdatableEntity<in TEntity> : IEntity
{
    void Update(TEntity model);
}