using System;
using OOP;

class Program
{
    static void Main()
    {
        var booking = new ServiceBooking(101);

        var master1 = new MasterSchedule("Alex");
        var master2 = new MasterSchedule("John");

        booking.Attach(master1);
        booking.Attach(master2);

        booking.ChangeStatus("In progress");
        booking.ChangeStatus("Completed");
    }
}
