using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using asp_core_mvc.Models;

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

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if(ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
                
            
        }

        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }
    }
}
