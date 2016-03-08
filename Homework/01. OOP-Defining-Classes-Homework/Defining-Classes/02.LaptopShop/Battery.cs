using System;

namespace _02.LaptopShop
{
    public class Battery
    {
        private string batteryModel;
        private double batteryLife;

        public Battery(string batteryModel, double batteryLife)
        {
            this.BatteryModel = batteryModel;
            this.BatteryLife = batteryLife;
        }

        public string BatteryModel
        {
            get { return this.batteryModel; }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Empty string");
                }
                this.batteryModel = value;
            }
        }

        public double BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Numeric data cannot be negative");
                }
                this.batteryLife = value;
            }
        }
    }
}