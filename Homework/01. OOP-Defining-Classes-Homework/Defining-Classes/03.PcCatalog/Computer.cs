using System;
using System.Collections.Generic;
using System.Text;

namespace _03.PcCatalog
{
    public class Computer
    {
        private string name;
        private decimal price;
        private List<Component> components = new List<Component>();

        public Computer(string name, List<Component> components)
        {
            this.Name = name;
            if (components != null)
            {
                for (int i = 0; i < components.Count; i++)
                {
                    this.components.Add(components[i]);
                }
                this.Price = CalcPrice(Components);
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Enter valid name!");
                }
                this.name = value;
            }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new FormatException("Price can't be negative!");
                }
                this.price = value;
            }
        }

        public List<Component> Components
        {
            get { return this.components; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Enter valid details!");
                }
                this.components = value;
            }
        }

        private decimal CalcPrice(List<Component> componentsList)
        {
            decimal totalPrice = 0;
            foreach (var component in componentsList)
            {
                totalPrice += component.ComponentPrice;
            }
            return totalPrice;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Computer name: {0}\n", this.Name);
            foreach (var component in components)
            {
                sb.Append(component);
            }
            sb.AppendFormat("Total computer price: {0}\n", this.Price);
            return sb.ToString();
        }
    }
}