using DesignPatterns_1.Models;
using DesignPatterns_1.Models.Interfaces;

namespace DesignPatterns_1.Services
{
    public class Icms : ITax
    {
        public double Calculate(Budget budget)
        {
            return budget.Value * 0.1;
        }
    }
}
