using System;

namespace OOP
{
    public class PremiumService : ServiceImplementor
    {
        public void PerformService(string serviceName)
        {
            Console.WriteLine($"Performing premium {serviceName}");
        }

        public decimal GetCost()
        {
            return 2000;
        }
    }
}

