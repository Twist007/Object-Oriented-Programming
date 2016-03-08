using System;

namespace Company_Hierarchy
{
    public abstract class Employee : Person
    {
        private decimal salary;
        //private DepartmanType departman;

        protected Employee(uint id, string firstName, string lastName,decimal salary,DepartmanType departman) 
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.DepartmanType = departman;
        }

        public DepartmanType DepartmanType { get; set; }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value<400)
                {
                    throw new ArgumentOutOfRangeException("Salary must be begger then 400");
                }
                this.salary = value;
            }
        }
    }
}
