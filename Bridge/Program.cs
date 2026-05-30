using OOP;

class Program
{
    static void Main()
    {
        ServiceImplementor standard = new StandardService();
        ServiceImplementor premium = new PremiumService();

        Service diagnostics = new CarService("Diagnostics", standard);
        Service oilChange = new CarService("Oil Change", premium);

        diagnostics.Execute();
        Console.WriteLine($"Price: {diagnostics.GetPrice()} UAH");

        oilChange.Execute();
        Console.WriteLine($"Price: {oilChange.GetPrice()} UAH");
    }
}

