using System.Collections.Generic;
using Capitalisam.Models;

namespace Capitalisam.Interfaces
{
    public interface IDatabases
    {
        ICollection<Company> Companies { get; }
    }
}