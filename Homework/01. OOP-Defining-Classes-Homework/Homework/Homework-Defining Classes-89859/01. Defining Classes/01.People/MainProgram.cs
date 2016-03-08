namespace Persons
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Person luke = new Person("Luke Skywalker", 19, "lwalker@rebels.com");

            luke.ToString();

            Person obiWan = new Person("Obi-Wan Kenobi", 57);

            obiWan.ToString();
        }
    }
}
