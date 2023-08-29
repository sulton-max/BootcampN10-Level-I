using N33_T1.DataAccess.EntityContext;

namespace N33_T1.Models.Entities;

public class User : IUpdatableEntity<User>
{
    public Guid Id { get; set; }

    public string UserName { get; set; }

    public string EmailAddress { get; set; }



    public void Update(User model)
    {
        Id = model.Id;
        UserName = model.UserName;
    }
}