using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    public class OrderMemento
    {
        public List<ServiceItem> Services { get; }
        public decimal TotalPrice { get; }

        public OrderMemento(List<ServiceItem> services)
        {
            Services = new List<ServiceItem>(services);
            TotalPrice = services.Sum(s => s.Price);
        }
    }
}
