using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dermapro.Controllers
{
    public class aboutController : MiddleController
    {
        // GET: about
        public ActionResult Index()
        {
            return View();
        }
    }
}