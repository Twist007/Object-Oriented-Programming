namespace Capitalisam.Models
{
    public class Salesman : Employee
    {
        private const double SalesmanSalaryFactor = 1.05;
        protected override double SalaryFactor
        {
            get { return SalesmanSalaryFactor; }
        }
    }
}
