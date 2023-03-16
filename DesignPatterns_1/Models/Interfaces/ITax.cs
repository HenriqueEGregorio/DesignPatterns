using Strategy.Models;

namespace Strategy.Models.Interfaces
{
    public interface ITax
    {
        double Calculate(Budget budget);
    }
}
