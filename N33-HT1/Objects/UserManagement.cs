using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N33_HT1.Classes;

namespace N33_HT1.Objects
{
    partial class UsersManagement
    {
        private List<UserModel> UserList = new()
        {
            new UserModel("John", "Doe", false),
            new UserModel("Jonibek", "Doniyorov", false),
            new UserModel("Jane", "Doe", true),
            new UserModel("Tommy", "Hilfiger", false),
            new UserModel("Mark", "Polo", true),
        };

        public ICollection<UserModel> GetByCreatedDate(bool includeAdmin)
        {
            return UserList.Where(user => includeAdmin || user.Admin == false).OrderByDescending(user => user.Created).ToList();
        }
    }
}
