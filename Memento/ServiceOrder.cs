using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    public class ServiceOrder
    {
        private List<ServiceItem> _services = new List<ServiceItem>();

        public void AddService(ServiceItem service)
        {
            _services.Add(service);
        }

        public void RemoveService(string name)
        {
            _services.RemoveAll(s => s.Name == name);
        }

        public OrderMemento Save()
        {
            return new OrderMemento(_services);
        }

        public void Restore(OrderMemento memento)
        {
            _services = new List<ServiceItem>(memento.Services);
        }

        public void Show()
        {
            Console.WriteLine("Services:");
            foreach (var s in _services)
            {
                Console.WriteLine($"- {s.Name}: {s.Price} UAH");
            }

            Console.WriteLine($"Total: {_services.Sum(s => s.Price)} UAH");
        }
    }
}
