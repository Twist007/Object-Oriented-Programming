using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PcCatalog
{
    class PcCatalogMain
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>();

            Component cpu1 = new Component("CPU", "Intel i3 2.0 GHz", 120);
            Component hdd1 = new Component("HDD", "250 GB", 50);
            Component ram1 = new Component("RAM", "500 MB", 70);
            Component gc1 = new Component("Graphic card", "512 MB", 100);
            
            Computer pc1 = new Computer("PC-1", new List<Component>() { cpu1, hdd1, ram1, gc1 });
            computers.Add(pc1);

            Component cpu2 = new Component("CPU", "Intel i7 2.7 GHz", 205);
            Component hdd2 = new Component("HDD", "700 GB", 99.99m);
            Component ram2 = new Component("RAM", "1 GB", 120.50m);
            Component gc2 = new Component("Graphic card", "1 GB", 170);

            Computer pc2 = new Computer("PC-2", new List<Component>() { cpu2, hdd2, ram2, gc2 });
            computers.Add(pc2);

            Component cpu3 = new Component("CPU", "Intel i5 2.2 GHz", 150);
            Component hdd3 = new Component("HDD", "250 GB", 50);
            Component ram3 = new Component("RAM", "500 GB", 70);
            Component gc3 = new Component("Graphic card", "2 GB", 240.69m);

            Computer pc3 = new Computer("PC-3", new List<Component>() { cpu3, hdd3, ram3, gc3 });
            computers.Add(pc3);

            computers = computers.OrderBy(pc => pc.Price).ToList();
            foreach (var pc in computers)
            {
                Console.WriteLine(pc);
            }

        }
    }
}
