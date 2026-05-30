namespace OOP
{
    public class ManagerHandler : Handler
    {
        protected override void Process(ServiceRequest request)
        {
            if (request.Complexity <= 3)
            {
                request.FinalPrice *= 1.1m;
                request.Comment = "Handled by manager.";
            }
        }
    }
}
