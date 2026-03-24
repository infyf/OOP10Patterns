namespace lr2
{
    public class Car : IVehicle
    {
        public string GetType() => "Car";

        public void Drive()
        {
            Console.WriteLine("Car is driving on the road.");
        }
    }
}
