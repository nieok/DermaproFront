using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dermapro.Controllers
{
    public class articleController : MiddleController
    {
        // GET: article
        public ActionResult Index()
        {
            return View();
        }
    }
}