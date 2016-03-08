using System.Collections.Generic;
using Capitalisam.Models.Interfaces;

namespace Capitalisam.Models
{
    public class CEO : PaidPerson, IBoss
    {
        public ICollection<IEmployee> SubordinateEmployee { get; set; }
    }
}