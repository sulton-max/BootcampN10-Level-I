using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N33_HT1.Classes
{
    public class UserModel
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public bool Admin { get; set; }

        public DateTime Created { get; set; }

        public UserModel(string firstname, string lastname, bool admin)
        {
            Id = Guid.NewGuid();
            Firstname = firstname;
            Lastname = lastname;
            Admin = admin;
            Created = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Firstname: {Firstname}, Lastname: {Lastname}, Admin: {Admin}, Created: {Created}";
        }
    }
}
