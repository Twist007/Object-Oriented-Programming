using System;

namespace DefiningClasses
{
    class MainClassPerson
    {
        static void Main(string[] args)
        {
            Person pesho = new Person("pesho", 15);
            pesho.Name = "Pesho Ivanov";
            pesho.Email = "pesho@";

            Person gosho = new Person("Gosho", 100, "gosho@");
            gosho.Age = 16;
            string output = gosho.ToString();

            Console.WriteLine(pesho.ToString());
            Console.WriteLine(output);

        }
    }
}
