using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;

namespace Dermapro.Models
{
    public class ProductRepository
    {
        dblinqDataContext db = new dblinqDataContext();
        private string ImageUrl = ConfigurationManager.AppSettings["ImageUrl"];
        private string ResizeImageUrl = ConfigurationManager.AppSettings["ResizeImageUrl"];
        private string HomeProductResizeImage = ConfigurationManager.AppSettings["HomeProductResizeImage"];
        private string HomeCategoryResizeImage = ConfigurationManager.AppSettings["HomeCategoryResizeImage"];


        public List<HomeProductItems> GetProductNewThisWeek()
        {
            return db.Products.ToList().Where(d => d.isPublished && !d.isDeleted && d.isFeatured).OrderByDescending(d => d.priority).Select(d => new HomeProductItems
            {
                id = d.id,
                title = d.title,
                subtitle = d.subtitle,
                categoryTitle = d.categoryId != null? d.Category.title:"",
                BrandTitle = d.brandId != null ? d.Brand.title : "",
                imgSrc = d.imgSrc != "" ? ResizeImageUrl + HomeProductResizeImage + Path.GetFileNameWithoutExtension(d.imgSrc) + ".webp" : null,

                ExternalLink = d.link
            }).ToList();
        }

        public List<HomeCategoryItem> GetAllCategoryHome()
        {
            return db.Categories.ToList().Where(d => d.isPublished && !d.isDeleted).OrderByDescending(d => d.priority).Select(d => new HomeCategoryItem
            {
                id = d.id,
                title = d.title,
                description = d.description,
                link = d.link,
                labelLink = d.labelLink,

                imgSrc = d.imgSrc != "" ? ResizeImageUrl + HomeCategoryResizeImage + Path.GetFileNameWithoutExtension(d.imgSrc) + ".webp" : null,
            }).ToList();
        }



    }
}