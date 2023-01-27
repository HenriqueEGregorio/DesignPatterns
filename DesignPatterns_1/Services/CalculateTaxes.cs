using DesignPatterns_1.Models;
using DesignPatterns_1.Models.Interfaces;

namespace DesignPatterns_1.Services
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
