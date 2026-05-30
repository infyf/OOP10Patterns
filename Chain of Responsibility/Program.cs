using System;
using OOP;

class Program
{
    static void Main()
    {
        var validation = new ValidationHandler();
        var manager = new ManagerHandler();
        var mechanic = new MechanicHandler();
        var director = new DirectorHandler();

        validation
            .SetNext(manager)
            .SetNext(mechanic)
            .SetNext(director);

        var request = new ServiceRequest(
            type: "Repair",
            complexity: 8,
            basePrice: 4000
        );

        validation.Handle(request);

        Console.WriteLine($"Approved: {request.Approved}");
        Console.WriteLine($"Final price: {request.FinalPrice}");
        Console.WriteLine($"Comment: {request.Comment}");
    }
}

