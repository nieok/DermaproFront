using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dermapro.Models;

namespace Dermapro.Controllers
{
    public class ServicesController : MiddleController
    {
        ServicesRepository ServicesRepos = new ServicesRepository();

        // GET: treatments
        public ActionResult Index(string category,string subcategory)
        {
            servicesPage Model = new servicesPage();
            Model = ServicesRepos.GetservicesPage(category, subcategory);
            return View(Model);
        }
    }
}