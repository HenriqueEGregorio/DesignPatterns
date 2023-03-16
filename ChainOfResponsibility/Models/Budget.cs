namespace ChainOfResponsibility.Models
{
    public class Budget
    {
        public double Value { get; set; }
        public List<Item> Items { get; set; }

        public Budget(double value)
        {
            Value = value;
            Items = new List<Item>();
        }

        public void AddsItem(Item item)
        {
            Items.Add(item);
        }
    }
}
