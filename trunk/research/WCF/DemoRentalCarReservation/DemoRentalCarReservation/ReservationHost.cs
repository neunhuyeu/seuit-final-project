using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;

namespace DemoRentalCarReservation
{
    public class ReservationHost
    {
        public static void Main()
        {
            ServiceHost s = new ServiceHost(typeof(RentalCarReservation));
            s.AddServiceEndpoint(typeof(RentalCarReservation), new WSHttpBinding(), "http://localhost/DemoRentalCarReservation_deploy/RentalCarReservation.svc");
            s.Open();
            Console.Write("Press ENTER to terminate the service");
            Console.ReadLine();
            s.Close();
        }
    }
}