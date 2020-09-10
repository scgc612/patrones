using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var appointmentResult = new AppointmentService2("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            
            var appointmentResult2 = new AppointmentService2("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            Console.WriteLine(AppointmentService2.PrintTicket(appointmentResult2));
        }
    }
}