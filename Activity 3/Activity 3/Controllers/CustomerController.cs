using Activity_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity_3.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer

        Customer customer;
        static List<Customer> customers = new List<Customer>(new CustomGenerator().GenerateCustomers(20));

        public CustomerController()
        {

        }

        public ActionResult Index()
        {
            // get some data - usually comes from a database

            //going to hard-code the data

            Tuple<List<Customer>, Customer> tuple;

            tuple = new Tuple<List<Customer>, Customer>(customers,customers[0]);
            return View("Customer", tuple);
        }

        [HttpPost]
        public ActionResult OnSelectCustomer(string CustomerNumber)
        {
            Tuple<List<Customer>, Customer> tuple;

            tuple = new Tuple<List<Customer>, Customer>(customers, customers[int.Parse(CustomerNumber)]);

            return PartialView("_CustomersDetails", customers[int.Parse(CustomerNumber)]);
        }
    }
}