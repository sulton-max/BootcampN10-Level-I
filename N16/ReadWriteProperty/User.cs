using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N16.ReadWriteProperty
{
    public class User
    {
        // Auto-property mashunga aylanadi
        //private string _firstName;
        //public string FirstName { get => _firstName; set => _firstName = value; }

        // Auto-property
        public string FirstName { get; set; }

        // Standard read-write property
        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentNullException(nameof(value));
            }
        }
    }
}
