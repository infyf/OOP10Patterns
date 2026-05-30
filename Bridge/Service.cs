namespace OOP
{
    public abstract class Service
    {
        protected ServiceImplementor _implementor;

        protected Service(ServiceImplementor implementor)
        {
            _implementor = implementor;
        }

        public abstract void Execute();
        public abstract decimal GetPrice();
    }
}
