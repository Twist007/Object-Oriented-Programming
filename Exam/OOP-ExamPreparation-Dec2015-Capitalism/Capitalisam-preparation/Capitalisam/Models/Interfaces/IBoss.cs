using System.Collections.Generic;

namespace Capitalisam.Models.Interfaces
{
    public interface IBoss
    {
        ICollection<IEmployee> SubordinateEmployee { get; }
    }
}
