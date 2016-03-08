using System;
using System.Collections;
using System.Collections.Generic;
using Capitalisam.Models.Interfaces;

namespace Capitalisam.Models
{
    public class Department : ICompanyStructure
    {
        private string name;
        private Manager manager;

        public Department()
        {
            this.Employees = new List<IEmployee>();
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value )|| value.Length < 5)
                {
                    throw new ArgumentNullException(nameof(value), "The name cannot be empty.");
                }
                this.name = value;
            }
        }

        public CEO CEO { get; set; }
        
        public ICollection<IEmployee> Employees { get; set; }

    }
}
