namespace OOP
{
    public class MechanicHandler : Handler
    {
        protected override void Process(ServiceRequest request)
        {
            if (request.Complexity > 3 && request.Complexity <= 7)
            {
                request.FinalPrice *= 1.3m;
                request.Comment = "Handled by mechanic.";
            }
        }
    }
}
