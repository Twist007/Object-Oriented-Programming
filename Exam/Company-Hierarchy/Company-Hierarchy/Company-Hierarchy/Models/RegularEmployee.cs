namespace Company_Hierarchy
{
   public class RegularEmployee:Employee
    {
       public RegularEmployee(uint id, string firstName, string lastName, decimal salary, DepartmanType departman)
            : base(id, firstName, lastName, salary, departman)
       {
       }
    }
}
