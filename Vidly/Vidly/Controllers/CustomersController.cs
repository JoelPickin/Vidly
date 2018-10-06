using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer {Id = 1, Name = "Joel Pickin"},
                new Customer {Id = 2, Name = "Caitlin Anderson"}
            };

            var vm = new CustomerViewModel
            {
                Customers = customers
            };

            return View(vm);
        }

        [Route("customers/Details/{customerId}")]
        public ActionResult Details(int customerId)
        {
            return View();
        }
    }
}