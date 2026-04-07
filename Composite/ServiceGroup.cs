using System;
using System.Collections.Generic;

namespace OOP
{
    public class ServiceGroup : ServiceComponent
    {
        private string _groupName;
        private List<ServiceComponent> _services = new List<ServiceComponent>();

        public ServiceGroup(string groupName)
        {
            _groupName = groupName;
        }

        public void Add(ServiceComponent service)
        {
            _services.Add(service);
        }

        public void Remove(ServiceComponent service)
        {
            _services.Remove(service);
        }

        public void Display()
        {
            Console.WriteLine($"Service Group: {_groupName}");
            foreach (var service in _services)
            {
                service.Display();
            }
        }

        public decimal GetPrice()
        {
            decimal total = 0;
            foreach (var service in _services)
            {
                total += service.GetPrice();
            }
            return total;
        }
    }
}
