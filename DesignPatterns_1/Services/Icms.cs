using Strategy.Models;
using Strategy.Models.Interfaces;

namespace Strategy.Services
{
    public class Icms : ITax
    {
        public double Calculate(Budget budget)
        {
            return budget.Value * 0.1;
        }
    }
}
