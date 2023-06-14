using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dermapro.Models;

namespace Dermapro.Controllers
{
    public class detailsController : MiddleController
    {
        ServicesRepository ServicesRepos = new ServicesRepository();

        // GET: details
        public ActionResult Index(string category, string subcategory, string Type, string Services)
        {
            servicesItem Model = new servicesItem();
            Model = ServicesRepos.GetservicesItem(subcategory, Type, Services);
            return View(Model);
        }
    }
}