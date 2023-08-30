using N33_HT1.Classes;
using N33_HT1.Objects;

var obj = new UsersManagement();
IEnumerable<UserModel> users = obj.GetByCreatedDate(false);

foreach (var user in users)
    Console.WriteLine(user);