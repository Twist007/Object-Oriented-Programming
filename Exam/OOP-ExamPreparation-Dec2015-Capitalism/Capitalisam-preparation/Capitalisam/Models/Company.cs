using System;
using System.Collections.Generic;
using Capitalisam.Models.Interfaces;

namespace Capitalisam.Models
{
    public class Company : ICompanyStructure
    {
        private string name;
        private CEO ceo;

        public Company(string name,CEO ceo)
        {
            this.Name = name;
            this.CEO = ceo;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "The name cannot be empty.");
                }
                this.name = value;
            }
        }

        public CEO CEO
        {
            get
            {
                return this.ceo;
            }
           private set
            {
                if (value==null)
                {
                    throw new ArgumentNullException("CEO","A company must have a CEO");
                }
                this.ceo = value;
            }
        }

        public ICollection<IEmployee> Employees { get; }

        public ICollection<Department> Departments { get; set; }
    }
}
