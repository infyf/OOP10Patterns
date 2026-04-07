using System;

namespace OOP
{
    public class ServiceItem : ServiceComponent
    {
        private string _name;
        private decimal _price;

        public ServiceItem(string name, decimal price)
        {
            _name = name;
            _price = price;
        }

        public void Display()
        {
            Console.WriteLine($"Service: {_name}, Price: {_price} UAH");
        }

        public decimal GetPrice()
        {
            return _price;
        }
    }
}
