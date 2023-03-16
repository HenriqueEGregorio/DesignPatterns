namespace ChainOfResponsibility.Models
{
    public class Item
    {
        public string Name { get; set; }
        public double Value { get; set; }

        public Item(string name, double value)
        {
            Name = name;
            Value = value;
        }
    }
}
