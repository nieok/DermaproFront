using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dermapro.Models
{
    public class PageItem
    {
        public int id { get; set; }
        public string title { get; set; }
        public string subtitle { get; set; }
        public string subtitle2 { get; set; }
        public string smallDescription { get; set; }
        public string Description { get; set; }
        public string imgSrc { get; set; }
        public string imgSrcSecondary { get; set; }
        public string videoSrc { get; set; }
        public string videoUrl { get; set; }
        public string labelLink { get; set; }
        public string Link { get; set; }
        public List<GalleryItem> Gallery { get; set; }


        public List<PageItem> SubPageItem { get; set; }

    }
    public class GalleryItem
    {
        public string image { get; set; }
    }


        public class HomeProductItems
    {
        public int id { get; set; }
        public string title { get; set; }
        public string subtitle { get; set; }
        public string categoryTitle { get; set; }
        public string BrandTitle { get; set; }
        public string ExternalLink { get; set; }
        public string Price { get; set; }   
        public string imgSrc { get; set; }
    }


    public class HomeCategoryItem
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string labelLink { get; set; }
        public string link { get; set; }
        public string imgSrc { get; set; }
        public string isFeatured { get; set; }

    }

    public class HomeBlogItem
    {
        public int id { get; set; }
        public string title { get; set; }
        public string smallDescription { get; set; }
        public string description { get; set; }
        public string BlogCategory { get; set; }

        public string imgSrc { get; set; }

    }


    public class HomePageModel
    {
        public PageItem HomeSlideShow { get; set; }
        public PageItem HomeOverview { get; set; }
        public PageItem HomeWeekProduct { get; set; }
        public List<HomeProductItems> HomeWeekProductItem { get; set; }

        public PageItem Homecategories { get; set; }
        public List<HomeCategoryItem> HomeCategoryItem { get; set; }

        public PageItem HomeAbout { get; set; }
        public PageItem HomeBlackBox { get; set; }
        public PageItem HomeBlogs { get; set; }

        public List<HomeBlogItem> BlogHomePageItem { get; set; }

        public PageItem HomeSponsors { get; set; }

        public PageItem Homecafe { get; set; }

        public PageItem HomeHighest { get; set; }
        public PageItem HomeVisit { get; set; }
    }

    public class CategoryMenu
    {
        public int id { get; set; }
        public string title { get; set; }
        public string link { get; set; }

        public List<CategoryMenu> SubcategoryMenu { get; set; }

    }

    public class servicesPage
    {
        public int id { get; set; }
        public string title { get; set; }
        public string smalldescription { get; set; }
        public string bannerImage { get; set; }
        public string LogoImage { get; set; }


        public List<typeServices> typeServices { get; set; }

        public List<servicesListing> servicesNoTypeListing { get; set; }


    }


    public class typeServices
    {
        public int id { get; set; }
        public string title { get; set; }
        public List<servicesListing> servicesListing { get; set; }

    }


    public class servicesListing
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public string link { get; set; }



    }


    public class servicesItem
    {
        public int id { get; set; }
        public string title { get; set; }
        public string smalldescription { get; set; }
        public string bannerImage { get; set; }
        public string LogoImage { get; set; }
        public string bookAppointmentLink { get; set; }
        public string consultationLink { get; set; }

        public List<servicesDetails> servicesDetails { get; set; }



        public string treatabletitle { get; set; }
        public string treatabledescription { get; set; }

        public List<servicesTreatable> servicesTreatableAreaItem { get; set; }
        public List<servicesGalleryItem> servicesGalleryItem { get; set; }
        public List<servicesFAQ> servicesFAQItem { get; set; }

        public List<servicesDoctor> servicesDoctorItem { get; set; }
        public List<servicesPackage> servicesPackageItem { get; set; }


    }


    public class servicesDetails
    {
        public int id { get; set; }
        public string title { get; set; }
        public string smalldescription { get; set; }
        public string Image { get; set; }
      
    }


    public class servicesTreatable
    {
        public int id { get; set; }
        public string title { get; set; }
        public string smalldescription { get; set; }
        public List<string> Areas { get; set; }

    }

    public class servicesGalleryItem
    {
        public string beforeImage { get; set; }
        public string AfterImage { get; set; }

    }

    public class servicesFAQ
    {
        public string title { get; set; }
        public string description { get; set; }

    }

    public class servicesDoctor
    {
        public string title { get; set; }
        public string position { get; set; }
        public string image { get; set; }

    }

    public class servicesPackage
    {
        public string title { get; set; }
        public string Price { get; set; }
        public string SmallDescription { get; set; }
        public string Link { get; set; }
    }

}