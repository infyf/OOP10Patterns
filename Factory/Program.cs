using lr2;

class Program
{
    static void Main()
    {
        IVehicle vehicle1 = VehicleFactory.CreateVehicle("car");
        IVehicle vehicle2 = VehicleFactory.CreateVehicle("bike");
        IVehicle vehicle3 = VehicleFactory.CreateVehicle("truck");

        Console.WriteLine(vehicle1.GetType());
        vehicle1.Drive();

        Console.WriteLine(vehicle2.GetType());
        vehicle2.Drive();

        Console.WriteLine(vehicle3.GetType());
        vehicle3.Drive();
    }
}
