using System;
using Company_Hierarchy.Interfaces;

namespace Company_Hierarchy
{
    class Customer : Person, ICustomer
    {
        private decimal balance;

        public Customer(uint id, string firstName, string lastName, decimal balanece)
            : base(id, firstName, lastName)
        {
        }

        public decimal Balance
        {
            get { return this.balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Balance must be begger positiv.");
                }
                this.balance = value;
            }
        }
    }
}
