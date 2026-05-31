using System.Collections.Generic;
using System.Runtime.InteropServices.JavaScript;

namespace OOP
{
    public class ServiceBooking : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();

        public int BookingId { get; }
        public string Status { get; private set; }

        public ServiceBooking(int id)
        {
            BookingId = id;
            Status = "Created";
        }

        public void ChangeStatus(string status)
        {
            Status = status;
            Notify();
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(Status);
            }
        }
    }
}

