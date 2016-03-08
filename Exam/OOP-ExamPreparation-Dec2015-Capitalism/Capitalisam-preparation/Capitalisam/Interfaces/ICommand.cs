using System.Collections.Generic;

namespace Capitalisam.Interfaces
{
    public interface ICommand
    {
         string Name { get;}

        IList<string> Parameters { get;  }
    }
}
