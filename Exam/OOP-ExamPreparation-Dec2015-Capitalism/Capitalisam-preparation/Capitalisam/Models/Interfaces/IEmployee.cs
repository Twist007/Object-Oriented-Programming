namespace Capitalisam.Models.Interfaces
{
    public interface IEmployee : IPaidPerson
    {
        Department Department { get; set; }
    }
}
