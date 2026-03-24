namespace lr2
{
    public class Bike : IVehicle
    {
        public string GetType() => "Bike";

        public void Drive()
        {
            Console.WriteLine("Bike is cycling on the street.");
        }
    }
}
