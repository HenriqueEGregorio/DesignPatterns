namespace ChainOfResponsibility.Models.Interfaces
{
    public interface IDiscount
    {
        double Calculate(Budget budget);
        IDiscount Next { get; set; }
    }
}
