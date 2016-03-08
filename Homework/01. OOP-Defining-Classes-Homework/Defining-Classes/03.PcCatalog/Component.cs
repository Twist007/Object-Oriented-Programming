using System;

namespace _03.PcCatalog
{
    public class Component
    {
        private string componentName;
        private decimal componentPrice;
        private string componentDetails;

        public Component(string componentName, string componentDetails, decimal componentPrice)
        {
            this.ComponentName = componentName;
            this.ComponentDetails = componentDetails;
            this.ComponentPrice = componentPrice;

        }

        public string ComponentDetails
        {
            get { return this.componentDetails; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    this.componentDetails = "(no details)";
                }
                this.componentDetails = value;
            }
        }

        public string ComponentName
        {
            get { return this.componentName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Enter valid name!");
                }
                this.componentName = value;
            }
        }

        public decimal ComponentPrice
        {
            get { return this.componentPrice; }
            set
            {
                if (value < 0)
                {
                    throw new FormatException("Price can't be negative!");
                }
                this.componentPrice = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Component: {0}: {1}; Price {2:f2}$\n",
                this.ComponentName, this.ComponentDetails, this.ComponentPrice);
        }
    }
}