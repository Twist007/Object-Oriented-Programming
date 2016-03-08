using System;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;
        private string eMail;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;

        }

        public Person(string name, int age) : this(name, age, "")
        {

        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name input!");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException("Age must be in range [1-100]!");
                }
                this.age = value;
            }
        }

        public string Email
        {
            get { return this.eMail; }
            set
            {
                if (!value.Contains("@") && !string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid email!");
                }
                this.eMail = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Person: {0}\nAge: {1}\nEmail: {2}", this.Name,
                this.Age, string.IsNullOrEmpty(this.Email) ? "no info" : this.Email);
        }
    }
}