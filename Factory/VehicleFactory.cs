namespace lr2
{
    public static class VehicleFactory
    {
        public static IVehicle CreateVehicle(string type)
        {
            return type.ToLower() switch
            {
                "car" => new Car(),
                "bike" => new Bike(),
                "truck" => new Truck(),
                _ => throw new ArgumentException("Unknown vehicle type")
            };
        }
    }
}
