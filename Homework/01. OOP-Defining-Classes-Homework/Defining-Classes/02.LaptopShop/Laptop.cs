using System;

namespace _02.LaptopShop
{
    public class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private decimal price;
        Battery battery;

        public Laptop(string model, decimal price) : this(model, null, null, 0, null, null, null, null, 0.0, price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, string processor, int ram, string hdd, decimal price) : this(model, null, processor, ram, null, hdd, null, null, 0.0, price)
        {
            this.Model = model;
            this.Processor = processor;
            this.Ram = ram;
            this.Hdd = hdd;
            this.Price = price;
        }
        public Laptop(string modell, string manufacturer, string processor, int ram, string graphicsCard, string hdd, string screen, string batteryModel, double batteryLife, decimal price)
        {
            this.Model = modell;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.Price = price;
            battery = new Battery(batteryModel, batteryLife);
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Unknown Model");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Empty string");
                }
                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get { return processor; }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Empty string");
                }
                this.processor = value;
            }
        }

        public int Ram
        {
            get { return this.ram; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Numeric data cannot be negative");
                }
                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Empty string");
                }
                this.graphicsCard = value;
            }
        }

        public string Hdd
        {
            get { return this.hdd; }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Empty string");
                }
                this.hdd = value;
            }
        }

        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Empty string");
                }
                this.screen = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Numeric data cannot be negative");
                }
                this.price = value;

            }
        }

        public override string ToString()
        {
            string result = "";
            result += "Model: " + this.Model + "\n";
            if (this.Manufacturer != null)
            {
                result += "Manufacturer: " + this.Manufacturer + "\n";
            }
            if (this.Processor != null)
            {
                result += "Processor: " + this.Processor + "\n";
            }
            if (this.Ram > 0)
            {
                result += "RAM: " + this.Ram + "\n";
            }
            if (this.GraphicsCard != null)
            {
                result += "Graphics Card: " + this.GraphicsCard + "\n";
            }
            if (this.Hdd != null)
            {
                result += "HDD: " + this.Hdd + "\n";
            }
            if (this.Screen != null)
            {
                result += "Screen: " + this.Screen + "\n";
            }
            if (battery.BatteryModel != null)
            {
                result += "Battery: " + battery.BatteryModel + "\n";
            }
            if (battery.BatteryLife > 0)
            {
                result += "Battery Life: " + battery.BatteryLife + " hours" + "\n";
            }
            result += "Price: " + this.Price + " lv" + "\n";
            return result;
        }
    }
}