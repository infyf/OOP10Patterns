
namespace lr2
{
    public class Truck : IVehicle
    {
        public string GetType() => "Truck";

        public void Drive()
        {
            Console.WriteLine("Truck is hauling cargo.");
        }
    }
}
