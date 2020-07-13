using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Activity2.Models
{
    public class AirlineTicket
    {
        public string PassengerName { get; set; }
        public string Terminal { get; set; }
        public string Destination { get; set; }
        public string CurrentCity { get; set; }
        public string Seat { get; set; }
        public DateTime Departure { get; set; }
        public int FlightNumber { get; set; }

        public AirlineTicket(string passengerName, string terminal, string destination, string currentCity, string seat, DateTime departure, int flightNumber)
        {
            PassengerName = passengerName;
            Terminal = terminal;
            Destination = destination;
            CurrentCity = currentCity;
            Seat = seat;
            Departure = departure;
            FlightNumber = flightNumber;
        }
    }
}