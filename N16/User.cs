using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N16
{
    internal class User
    {
        public readonly string _name;

        public string Name { get => _name; init => _name = value;  }

        public void DoSomething(out int valueB, in int valueA, ref int valueC, int valueD = 10, params int[] values)
        {
            valueB = 10;
        }
    }
}
