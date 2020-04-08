using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Form4Life.Models;

namespace Form4Life.Controllers
{
    public class SquatFormController : Controller
    {
        // GET: SquatForm
        public ActionResult Form()
        {
            ViewBag.Message = "How to squat 101";
            var squat = new Squat() {Form = "High Bar!"};
            return View(squat);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
    }
}