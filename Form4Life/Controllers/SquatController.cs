using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Form4Life.Models;
using Form4Life.ViewModels;

namespace Form4Life.Controllers
{
    public class SquatController : Controller
    {
        // GET: Squat
        public ActionResult SquatForm()
        {
            var squat = new Squat();
            var subscribers = new List<Subscribers>
            {
                new Subscribers {Name = "Luke Thao"},
                new Subscribers {Name = "Ryan Manchanthasouk"}
            };

            var viewModel = new SquatViewModel
            {
                Squat = squat,
                Subscribers = subscribers
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
    }
}