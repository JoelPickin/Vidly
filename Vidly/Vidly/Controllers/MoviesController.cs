using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Index

        public ActionResult Index()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer {Id = 1, Name = "Joel Pickin"},
                new Customer {Id = 2,Name = "Caitlin Anderson"}
            };

            var viewModel = new MovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2})}")]
        public ActionResult MoviesByReleaseDate()
        {
            return View();
        }
    }
}