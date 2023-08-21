using N28.Models.Common;

namespace N28.Models.Entities;

public class User :  IEntity, IUpdatableEntity<User>
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void Update(User model)
    {
        FirstName = model.FirstName;
        LastName = model.LastName;
    }

    public User(string firstName, string lastName)
    {
        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
    }
}