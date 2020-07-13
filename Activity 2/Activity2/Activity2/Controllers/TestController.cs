using Activity2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity2.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            //make a list of users

            //usually this would be from a datasource

            //we will hard code the values in this class

            List<UserModel> users = new List<UserModel>();
            users.AddRange(new GenerateObjects().GenerateSomeUsers(20));  //calls on my custom generate users class
            return View("Test",users);
        }
        public ActionResult FlightTimes()
        {
            List<AirlineTicket> flights = new List<AirlineTicket>(new GenerateObjects().GetAirlineTickets(new Random().Next(1)+10));
            flights.Sort((a, b) => (a.PassengerName.CompareTo(b.PassengerName)));
            Debug.WriteLine("Flights active: "+flights.Count);
            return View("FlightTimes", flights);
        }

    }
}