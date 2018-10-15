using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hello_Git.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var x = 0;
            x++;
            return View();
        }

        
    }
}