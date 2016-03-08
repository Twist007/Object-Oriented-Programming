using System;

namespace _02.LaptopShop
{
    public class LaptopShop
    {
        public static void Main(string[] args)
        {
            Laptop laptopLenovo = new Laptop("Lenovo ThinkPad", 2500.00m);
            Console.WriteLine(laptopLenovo.ToString());

            Laptop laptopDell = new Laptop("Dell Inspiron", "Intel i7", 6, "500 GB", 1400.00m);
            Console.WriteLine(laptopDell.ToString());

            Laptop laptopLenovoY = new Laptop("Y50-70", "Lenovo", "Intel core i7", 16, "Nvidia", "1 TB", "LCD 17", "Li-Ion 6 cells", 5, 2700.00m);
            Console.WriteLine(laptopLenovoY.ToString());

        }
    }
}