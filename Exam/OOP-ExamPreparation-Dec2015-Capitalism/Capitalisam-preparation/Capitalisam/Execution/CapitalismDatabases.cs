using System.Collections.Generic;
using Capitalisam.Interfaces;
using Capitalisam.Models;

namespace Capitalisam.Execution
{
    public class CapitalismDatabases : IDatabases
    {
        public CapitalismDatabases()
        {
            this.Companies=new List<Company>();
        }
        public ICollection<Company> Companies { get; set; }
    }
}
