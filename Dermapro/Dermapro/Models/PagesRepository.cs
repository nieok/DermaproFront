using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;

namespace Dermapro.Models
{
    public class PagesRepository
    {
        dblinqDataContext db = new dblinqDataContext();
        private string ImageUrl = ConfigurationManager.AppSettings["ImageUrl"];
        private string ResizeImageUrl = ConfigurationManager.AppSettings["ResizeImageUrl"];

        public PageItem PagesById(int id, int templateId, string ImageSize,string subImageSize)
        {
            return db.CorporatePageSections.ToList().Where(d => d.isPublished && !d.isDeleted && d.corporatePageId == id && d.corporatePageTemplateId == templateId).OrderByDescending(d => d.priority).Select(d => new PageItem
            {
                subtitle = d.subtitle,
                subtitle2 = d.subtitle1,
                smallDescription = d.smallDescription,
                Description = d.description,
                imgSrc = d.imgSrc != "" ? ResizeImageUrl + ImageSize + Path.GetFileNameWithoutExtension(d.imgSrc) + ".webp" : null,
                imgSrcSecondary = d.imgSrc != "" ? ResizeImageUrl + subImageSize + Path.GetFileNameWithoutExtension(d.imgSrcSecondary) + ".webp" : null,

                labelLink = d.labelLink,
                Link = d.link,
                Gallery = d.CorporatePageSectionMedias.ToList().OrderByDescending(z => z.priority).Select(z => new GalleryItem { image = ResizeImageUrl + ImageSize + Path.GetFileNameWithoutExtension(z.mediaSrc) + ".webp" }).ToList(),
                SubPageItem = db.CorporatePageSections.ToList().Where(x => x.isPublished && !x.isDeleted && x.subCorporatePageId == d.id).OrderByDescending(x => x.priority).Select(x => new PageItem
                {
                    id = x.id,
                    title = x.title,
                    smallDescription = x.smallDescription,
                    Description = x.description,
                    imgSrc = x.imgSrc != "" ? ResizeImageUrl + subImageSize + Path.GetFileNameWithoutExtension(x.imgSrc)+".webp" : null,

                    labelLink = x.labelLink,
                    Link = x.link,
                }).ToList(),
            }).FirstOrDefault();
        }

      

    }
}