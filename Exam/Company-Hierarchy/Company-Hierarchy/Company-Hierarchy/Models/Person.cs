using System;
using Company_Hierarchy.Interfaces;

namespace Company_Hierarchy
{
    public abstract class Person : IPerson
    {
        private uint id;
        private string firstName;
        private string lasName;

        protected Person(uint id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public uint Id { get; set; }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First name cannot be empty.");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lasName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last name cannot be empty.");
                }
                this.lasName = value;
            }
        }

    }
}
