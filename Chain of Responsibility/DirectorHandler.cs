namespace OOP
{
    public class DirectorHandler : Handler
    {
        protected override void Process(ServiceRequest request)
        {
            if (request.Complexity > 7)
            {
                request.FinalPrice *= 1.6m;
                request.Comment = "Approved by director.";
            }
        }
    }
}
