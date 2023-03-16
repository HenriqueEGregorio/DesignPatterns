using ChainOfResponsibility.Models;
using ChainOfResponsibility.Models.Interfaces;

namespace ChainOfResponsibility.Services
{
    internal class NoDiscounts : IDiscount
    {
        public IDiscount Next { get; set;}

        public double Calculate(Budget budget)
        {
            return 0;
        }
    }
}
