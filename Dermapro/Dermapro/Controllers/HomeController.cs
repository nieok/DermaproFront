using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dermapro.Models;

namespace Dermapro.Controllers
{
    public class HomeController : MiddleController
    {
        PagesRepository PagesRepos = new PagesRepository();
        ProductRepository ProductRepos = new ProductRepository();
        BlogRepository BlogRepos = new BlogRepository();


        string BannerImage = ConfigurationManager.AppSettings["BannerImage"];
        string SolganImage = ConfigurationManager.AppSettings["SolganImage"];

        public ActionResult Index()
        {
            HomePageModel Model = new HomePageModel();
            int HomePageId = Convert.ToInt32(ConfigurationManager.AppSettings["HomePageId"]);

            int HomeSlideShow = Convert.ToInt32(ConfigurationManager.AppSettings["HomeSlideShow"]);
            int HomeOverview = Convert.ToInt32(ConfigurationManager.AppSettings["HomeOverview"]);
            int HomeWeekProduct = Convert.ToInt32(ConfigurationManager.AppSettings["HomeWeekProduct"]);
            int Homecategories = Convert.ToInt32(ConfigurationManager.AppSettings["Homecategories"]);
            int HomeAbout = Convert.ToInt32(ConfigurationManager.AppSettings["HomeAbout"]);
            int HomeBlackBox = Convert.ToInt32(ConfigurationManager.AppSettings["HomeBlackBox"]);
            int HomeBlogs = Convert.ToInt32(ConfigurationManager.AppSettings["HomeBlogs"]);
            int HomeSponsors = Convert.ToInt32(ConfigurationManager.AppSettings["HomeSponsors"]);
            int HomeHighest = Convert.ToInt32(ConfigurationManager.AppSettings["HomeHighest"]);
            int HomeVisit = Convert.ToInt32(ConfigurationManager.AppSettings["HomeVisit"]);
            int Homecafe = Convert.ToInt32(ConfigurationManager.AppSettings["Homecafe"]);


            string SlideShowImage = ConfigurationManager.AppSettings["SlideShowImage"];
            string BrandImage = ConfigurationManager.AppSettings["BrandImage"];
            string HomeBlackBoxImage = ConfigurationManager.AppSettings["HomeBlackBoxImage"];
            string HomeBlogImage = ConfigurationManager.AppSettings["HomeBlogImage"];
            string HomeSponsorsImage = ConfigurationManager.AppSettings["HomeSponsorsImage"];
            string HomedermaprocafeImage = ConfigurationManager.AppSettings["HomedermaprocafeImage"];
            string HomedermaprocafeLogo = ConfigurationManager.AppSettings["HomedermaprocafeLogo"];


            Model.HomeSlideShow = PagesRepos.PagesById(HomePageId, HomeSlideShow, SlideShowImage, SlideShowImage);
            Model.HomeOverview = PagesRepos.PagesById(HomePageId, HomeOverview, null, null);
            Model.HomeWeekProduct= PagesRepos.PagesById(HomePageId, HomeWeekProduct, null, null);
            Model.HomeWeekProductItem = ProductRepos.GetProductNewThisWeek();

            Model.Homecategories = PagesRepos.PagesById(HomePageId, Homecategories, null, null);
            Model.HomeCategoryItem = ProductRepos.GetAllCategoryHome();


            Model.HomeBlackBox = PagesRepos.PagesById(HomePageId, HomeBlackBox, null, HomeBlackBoxImage);

            Model.HomeBlogs = PagesRepos.PagesById(HomePageId, HomeBlogs, null, HomeBlogImage);
            Model.BlogHomePageItem = BlogRepos.GetBlogHomePage();

            Model.HomeSponsors = PagesRepos.PagesById(HomePageId, HomeSponsors, HomeSponsorsImage, null);

            Model.Homecafe = PagesRepos.PagesById(HomePageId, Homecafe, HomedermaprocafeImage, HomedermaprocafeLogo);

            Model.HomeHighest = PagesRepos.PagesById(HomePageId, HomeHighest, null, null);




            return View(Model);
        }

       
    }
}