using Strategy.Models;
using Strategy.Models.Interfaces;

namespace Strategy.Services
{
    public class Iccc : ITax
    {
        public double Calculate(Budget budget)
        {
            var value = budget.Value;

            if(value < 1000)
            {
                return value * 0.05;
            }
            else if (value < 3000)
            {
                return value * 0.07;
            }
            else
            {
                return value * 0.08 + 30;
            }
        }
    }
}
