using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewData_Demo.Models;

namespace ViewData_Demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Message"] = "Message From the View Data!!!";
            ViewData["Currunt Time :"] = DateTime.Now.ToLongDateString();

            string[] fruit = { "Apple","Mango","Banana"};
            ViewData["FruitArray"]= fruit;

            ViewData["SportData"] = new List<string>()
            {
                "Cricket",
                "Hokey",
                "BasketBall"

            };


            Employee emp=new Employee();
            emp.Id = 1;
            emp.Name = "Gaurav";
            emp.Designation = "Manager";

            ViewData["Employee"]= emp;
            return View();
        }
    }
}