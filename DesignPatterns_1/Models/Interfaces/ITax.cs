using DesignPatterns_1.Models;

namespace DesignPatterns_1.Models.Interfaces
{
    public interface ITax
    {
        double Calculate(Budget budget);
    }
}
