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
                new Customer {Name = "Joel Pickin"},
                new Customer {Name = "Caitlin Anderson"}
            };

            var vm = new CustomerViewModel
            {
                Customers = customers
            };

            return View(vm);
        }
    }
}