using System;

namespace OOP
{
    public class StandardService : ServiceImplementor
    {
        public void PerformService(string serviceName)
        {
            Console.WriteLine($"Performing standard {serviceName}");
        }

        public decimal GetCost()
        {
            return 1000;
        }
    }
}
