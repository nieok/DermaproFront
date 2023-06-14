using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dermapro.Models;

namespace Dermapro.Controllers
{
    public class MiddleController : Controller
    {
        ServicesRepository ServicesRepos = new ServicesRepository();

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ViewBag.categoryMenu = ServicesRepos.GetCategoryMenu();

        }


    }
}