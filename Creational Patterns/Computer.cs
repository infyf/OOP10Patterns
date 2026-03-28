namespace OOP
{
    public class Computer
    {
        public string CPU { get; set; }
        public string GPU { get; set; }
        public int RAM { get; set; }
        public int Storage { get; set; }

        public void ShowConfiguration()
        {
            Console.WriteLine("Computer configuration:");
            Console.WriteLine($"CPU: {CPU}");
            Console.WriteLine($"GPU: {GPU}");
            Console.WriteLine($"RAM: {RAM} GB");
            Console.WriteLine($"Storage: {Storage} GB");
        }
    }
}
