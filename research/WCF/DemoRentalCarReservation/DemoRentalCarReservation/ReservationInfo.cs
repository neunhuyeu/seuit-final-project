using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace DemoRentalCarReservation
{
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class ReservationInfo
    {
        private int _vehicleClass = 0;
        private int _location = 0;
        private string _dates = "Hello";

        [DataMember]
        public int VehicleClass
        {
            get { return _vehicleClass; }
            set { _vehicleClass = value; }
        }

        [DataMember]
        public int Location
        {
            get { return _location; }
            set { _location = value; }
        }

        [DataMember]
        public string Dates
        {
            get { return _dates; }
            set { _dates = value; }
        }
    }
}