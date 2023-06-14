using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dermapro.Controllers
{
    public class errorController : MiddleController
    {
        // GET: error
        public ActionResult pagenotfound()
        {
            return View();
        }
        public ActionResult server()
        {
            return View();
        }
    }
}