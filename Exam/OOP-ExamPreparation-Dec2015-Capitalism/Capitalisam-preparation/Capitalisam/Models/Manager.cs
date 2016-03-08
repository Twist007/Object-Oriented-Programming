using System.Collections.Generic;
using Capitalisam.Models.Interfaces;

namespace Capitalisam.Models
{
    public class Manager : PaidPerson,IBoss
    {
        public ICollection<IEmployee> SubordinateEmployee { get; }
    }
}
