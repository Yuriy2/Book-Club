using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IUser : IPerson
    {
        string Email { get; }
        string Phone { get; }
        string Country { get; }
        int Age { get; }
    }
}
