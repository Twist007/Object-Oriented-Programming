using System;
using Capitalisam.Models.Interfaces;

namespace Capitalisam.Models
{
    public abstract class PaidPerson : IPaidPerson
    {
        private string firstName;
        private string lastName;
        private decimal salary;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
                {
                    throw new ArgumentNullException("The name should be valid.");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
                {
                    throw new ArgumentNullException("The name should be valid.");
                }
                this.lastName = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "The salary should be positive.");
                }
                this.salary = value;
            }
        }
    }
}
