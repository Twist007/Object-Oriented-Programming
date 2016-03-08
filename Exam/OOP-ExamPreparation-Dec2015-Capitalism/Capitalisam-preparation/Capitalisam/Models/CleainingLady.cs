namespace Capitalisam.Models
{
    public class CleainingLady : Employee
    {
        protected override double SalaryFactor
        {
            get { return 0.98; }
        }
    }
}
