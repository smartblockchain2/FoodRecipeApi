using recipeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace recipeAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Application ID
            //59d201f4

            //This is the application ID, you should send with each API request.
            //Application Keys
            //a43629aaaebb6aef4e036fee8960388b

            Recipe recipe = new Recipe();
            return View(recipe);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Prototype jQuery API call using Edamam API.";

            return View();
        }

        public ActionResult Contact()
        {
            // ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}