namespace Capitalisam.Models
{
    public class ChiefTelephoneOfficer : Employee
    {
        protected override double SalaryFactor
        {
            get { return 0.98; }
        }
    }
}
