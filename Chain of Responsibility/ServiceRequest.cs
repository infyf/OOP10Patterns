namespace OOP
{
    public class ServiceRequest
    {
        public string Type { get; }
        public int Complexity { get; }
        public decimal BasePrice { get; }

        public bool Approved { get; set; }
        public decimal FinalPrice { get; set; }
        public string Comment { get; set; }

        public ServiceRequest(string type, int complexity, decimal basePrice)
        {
            Type = type;
            Complexity = complexity;
            BasePrice = basePrice;
            Approved = true;
            FinalPrice = basePrice;
        }
    }
}
