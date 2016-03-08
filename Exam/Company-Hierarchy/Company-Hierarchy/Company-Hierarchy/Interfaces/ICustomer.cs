namespace Company_Hierarchy.Interfaces
{
    interface ICustomer : IPerson
    {
        decimal Balance { get; set; }
    }
}
