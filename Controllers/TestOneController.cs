using System;
using Microsoft.AspNetCore.Mvc;

namespace asp_core_mvc.Controllers
{
    public class TestOneController : Controller
    {
       
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Доброго утра"  : "Доброго дня";
            return View("MyView");
        }
        
        // public string Index()
        // {
        //     return "Hello World";
        // }
    }
}
