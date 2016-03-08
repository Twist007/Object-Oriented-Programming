using System;
using System.Collections.Generic;

namespace Company_Hierarchy
{
    class SalesEmployee : RegularEmployee
    {
        private List<Sale> sales; 

        public SalesEmployee(uint id, string firstName, string lastName, decimal salary, DepartmanType departman)
            : base(id, firstName, lastName, salary, departman)
        {
            this.sales=new List<Sale>();
        }

        public IEnumerable<Sale> Sales { get; set; }

        public void AddSale(Sale sale)
        {
            if (sale.Price<=0)
            {
                throw new ArgumentException("Price must be positive.");
            }
            this.sales.Add(sale);
        }
    }
}
