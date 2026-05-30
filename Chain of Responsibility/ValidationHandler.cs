namespace OOP
{
    public class ValidationHandler : Handler
    {
        protected override void Process(ServiceRequest request)
        {
            if (request.Complexity < 1 || request.Complexity > 10)
            {
                request.Approved = false;
                request.Comment = "Invalid service complexity.";
            }
        }
    }
}

