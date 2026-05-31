using System;

namespace OOP
{
    public class MasterSchedule : IObserver
    {
        private string _masterName;

        public MasterSchedule(string masterName)
        {
            _masterName = masterName;
        }

        public void Update(string status)
        {
            if (status == "In progress")
            {
                Console.WriteLine($"{_masterName} is now busy with the order.");
            }
            else if (status == "Completed")
            {
                Console.WriteLine($"{_masterName} finished the order and is available.");
            }
        }
    }
}

