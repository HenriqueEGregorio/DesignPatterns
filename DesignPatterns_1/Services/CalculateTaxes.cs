using Strategy.Models;
using Strategy.Models.Interfaces;

namespace Strategy.Services
{
    public class CalculateTaxes
    {
        public void Calculate (Budget budget,ITax tax)
        {
            double value = tax.Calculate(budget);
            Console.WriteLine(value);
        }
    }
}
