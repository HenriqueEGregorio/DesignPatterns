using ChainOfResponsibility.Models;
using ChainOfResponsibility.Models.Interfaces;
using static System.Net.Mime.MediaTypeNames;

namespace ChainOfResponsibility.Services
{
    public class ValueDiscount : IDiscount
    {
        public IDiscount Next { get; set; }

        public double Calculate(Budget budget)
        {
            if (budget.Value > 500)
                return budget.Value * 0.07;

            return Next.Calculate(budget);
        }
    }
}
