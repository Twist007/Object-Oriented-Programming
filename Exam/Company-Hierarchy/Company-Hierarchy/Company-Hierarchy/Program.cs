using System;
using System.Collections.Generic;
using Company_Hierarchy.Interfaces;

namespace Company_Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer=new Customer(10,"kaka","minka",450);

            Manager manager=new Manager(10, "chicho", "mincho", 500,DepartmanType.Accounting);

            Developer developer=new Developer(333,"bai","stavri",1000,DepartmanType.Production);

            List<IPerson> persons=new List<IPerson>();
            persons.Add(customer);
            persons.Add(developer);
            persons.Add(manager);

            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
        }
    }
}
0