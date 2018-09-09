using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMVCApp.Models;

namespace MyMVCApp.Controllers
{
    public class MyfirstController : Controller
    {
        // GET: Myfirst
        public ActionResult Index()
        {
            Employee e = new Employee();
            e.Id = 100;
            e.Ename = "SBM";
            ViewData["Date"] = DateTime.Now.ToString();
            return View(e);
        }
        public ActionResult Index2()
        {
            
            return View("MySecond");
        }

    }
}