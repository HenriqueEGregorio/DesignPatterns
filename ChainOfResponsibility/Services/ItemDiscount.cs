using ChainOfResponsibility.Models;
using ChainOfResponsibility.Models.Interfaces;

namespace ChainOfResponsibility.Services
{
    public  class ItemDiscount : IDiscount
    {
        public IDiscount Next { get; set; }
        public double Calculate(Budget budget)
        {
            if (budget.Items.Count > 5)
                return budget.Value * 0.1;

            return Next.Calculate(budget) ;
        }
    }
}
