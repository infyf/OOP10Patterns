namespace OOP
{
    public interface IComputerBuilder
    {
        void SetCPU();
        void SetGPU();
        void SetRAM();
        void SetStorage();
        Computer GetComputer();
    }
}
