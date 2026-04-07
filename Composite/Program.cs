using OOP;


class Program
{
    static void Main()
    {
        ServiceComponent oilChange =
            new ServiceItem("oil Change", 1200);

        ServiceComponent diagnostics =
            new ServiceItem("computer Diagnostics", 800);

        ServiceComponent brakeRepair =
            new ServiceItem("brake Repair", 2500);

        ServiceGroup maintenance = new ServiceGroup("Maintenance");
        maintenance.Add(oilChange);
        maintenance.Add(diagnostics);

        ServiceGroup fullService = new ServiceGroup("Full Service");
        fullService.Add(maintenance);
        fullService.Add(brakeRepair);

        fullService.Display();

        Console.WriteLine(
            $"Total price: {fullService.GetPrice()} UAH"
        );
    }
}
