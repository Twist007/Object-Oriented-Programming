namespace Company_Hierarchy.Interfaces
{
    public interface IEmployee : IPerson
    {
        DepartmanType DepartmanType { get; set; }
    }
}
