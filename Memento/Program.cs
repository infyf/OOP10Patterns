using System;
using OOP;

class Program
{
    static void Main()
    {
        var order = new ServiceOrder();
        var history = new History();

        // початковий стан
        history.Save(order.Save());

        order.AddService(new ServiceItem("Діагностика", 800));
        history.Save(order.Save());

        order.AddService(new ServiceItem("заміна масла", 1200));
        history.Save(order.Save());

        order.AddService(new ServiceItem("Brake Repair", 2500));
        history.Save(order.Save());

        order.RemoveService("заміна масла");

        Console.WriteLine("Поточний стан:");
        order.Show();

        Console.WriteLine("\nСкасувати останню зміну:");

        order.Restore(history.Undo());
        order.Show();
    }
}
