namespace OOP
{
    public abstract class Handler
    {
        protected Handler _next;

        public Handler SetNext(Handler next)
        {
            _next = next;
            return next;
        }

        public void Handle(ServiceRequest request)
        {
            if (!request.Approved)
                return;

            Process(request);
            _next?.Handle(request);
        }

        protected abstract void Process(ServiceRequest request);
    }
}
