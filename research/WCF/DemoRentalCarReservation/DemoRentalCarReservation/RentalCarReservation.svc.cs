using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DemoRentalCarReservation
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class RentalCarReservation : IReservations
    {
        #region IReservations Members

        public bool Check(int vehicleClass, int location, string dates)
        {
            bool available = false;

            // Logic code to check availability goes here.

            return available;
        }

        public int Reserve(int vehicleClass, int location, string dates)
        {
            int confirmationNumber = 654321;

            // Logic code to reserve rental car goes here
            
            return confirmationNumber;
        }

        public bool Cancel(int confirmationNumber)
        {
            bool done = false;

            // Logic code to cancel reservation goes here.

            return done;
        }

        #endregion

        public int GetStats()
        {
            int numOfReservation = 0;

            // Logic code to get the number of reservations goes here.

            return numOfReservation;
        }
    }
}
