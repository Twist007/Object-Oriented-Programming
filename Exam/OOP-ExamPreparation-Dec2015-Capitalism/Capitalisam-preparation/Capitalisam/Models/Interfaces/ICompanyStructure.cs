using System.Collections.Generic;

namespace Capitalisam.Models.Interfaces
{
  public interface ICompanyStructure
    {
       string Name { get; }

       ICollection<IEmployee> Employees { get; }
    }
}
