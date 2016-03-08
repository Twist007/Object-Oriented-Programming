using System;

namespace OOP_Lab_Football.Models
{
    public class Player
    {
        private const int MinimumAllowedYear = 1980;

        private string firstName;
        private string lstName;
        private DateTime dateOfBirth;
        private decimal salary;
        private Team team;

        public Player(string firstName, string lastName, DateTime dateOfBirth, decimal salary, Team team)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Salary = salary;
            this.Team = team;
        }
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (chekName(value))
                {
                    throw new ArgumentException("First name should be at last 3 chars long!");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lstName; }
            set
            {
                if (chekName(value))
                {
                    throw new ArgumentException("Last name should be at last 3 chars long!");
                }
                this.firstName = value;
            }
        }

        private decimal Salary 
        {
            get { return this.salary; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Salary can't be negative!");
                }
                this.salary = value;
            }
        }

        public DateTime DateOfBirth
        {
            get { return this.dateOfBirth; }
            set
            {
                if (value.Year<MinimumAllowedYear)
                {
                    throw new ArgumentException("Date of birth cannot be earlier than "+MinimumAllowedYear);
                }
                this.dateOfBirth = value;
            }
        }

        public Team Team { get; set; }

        private bool chekName(string name)
        {
            return string.IsNullOrEmpty(name) || name.Length < 3;
        }
    }
}