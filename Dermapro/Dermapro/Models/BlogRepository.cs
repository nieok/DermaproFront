using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;

namespace Dermapro.Models
{
    public class BlogRepository
    {
        dblinqDataContext db = new dblinqDataContext();
        private string ImageUrl = ConfigurationManager.AppSettings["ImageUrl"];
        private string ResizeImageUrl = ConfigurationManager.AppSettings["ResizeImageUrl"];
        private string HomeBlogImage = ConfigurationManager.AppSettings["HomeBlogImage"];


        public List<HomeBlogItem> GetBlogHomePage()
        {
            return db.Blogs.ToList().Where(d => d.isPublished && !d.isDeleted && d.isFeatured).OrderByDescending(d => d.priority).Select(d => new HomeBlogItem
            {
                id = d.id,
                title = d.title,
                BlogCategory = d.BlogCategory.title,

                smallDescription = d.smallDescription,
                description = d.description,
                imgSrc = d.imgSrc != "" ? ResizeImageUrl + HomeBlogImage + Path.GetFileNameWithoutExtension(d.imgSrc) + ".webp" : null,

            }).ToList();
        }


    



    }
}