using OOP;

class Program
{
    static void Main()
    {
        IComputerBuilder gamingBuilder = new GamingComputerBuilder();
        ComputerDirector director = new ComputerDirector(gamingBuilder);
        director.BuildComputer();
        Computer gamingPC = gamingBuilder.GetComputer();
        gamingPC.ShowConfiguration();

        Console.WriteLine();

        IComputerBuilder officeBuilder = new OfficeComputerBuilder();
        director = new ComputerDirector(officeBuilder);
        director.BuildComputer();
        Computer officePC = officeBuilder.GetComputer();
        officePC.ShowConfiguration();
    }
}
