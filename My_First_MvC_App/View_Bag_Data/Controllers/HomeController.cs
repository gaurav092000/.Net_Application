using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View_Bag_Data.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message = "Messgae from View Bag";
            ViewBag.Curruntdate= DateTime.Now.ToLongDateString();

            string[] fruit = { "Apple","Mango","Bananaa"};

            ViewBag.FruitArray= fruit;

            return View();
        }
    }
}