namespace OOP
{
    public class ServiceItem
    {
        public string Name { get; }
        public decimal Price { get; }

        public ServiceItem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
