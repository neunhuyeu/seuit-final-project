using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DemoRentalCarClient.RentalcarReference;
namespace DemoRentalCarClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initializing service proxy");
            ReservationsClient client = new ReservationsClient();
            Console.WriteLine("Client credentials: {0}", client.ClientCredentials.ClientCertificate);

            Console.WriteLine("Calling service...");
            // Use the 'client' variable to call operations on the service.
            bool checkResult = client.Check(1, 1, "9/22/2010");

            Console.WriteLine("Result: {0}", checkResult);

            // Always close the client.
            client.Close();

        }
    }
}
