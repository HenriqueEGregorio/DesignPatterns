using ChainOfResponsibility.Models;
using ChainOfResponsibility.Models.Interfaces;

namespace ChainOfResponsibility.Services
{
    public class CalculateDiscounts
    {
        public double Calculate(Budget budget)
        {
            var d1 = new ValueDiscount();
            var d2 = new ItemDiscount();
            var d3 = new NoDiscounts();

            d1.Next = d2;
            d2.Next = d3;

            return d1.Calculate(budget);
        }
    }
}
