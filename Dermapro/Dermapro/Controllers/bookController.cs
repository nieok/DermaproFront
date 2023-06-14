using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dermapro.Controllers
{
    public class bookController : MiddleController
    {
        // GET: book
        public ActionResult Index()
        {
            return View();
        }
    }
}