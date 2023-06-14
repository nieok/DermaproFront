using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;

namespace Dermapro.Models
{
    public class ServicesRepository
    {
        dblinqDataContext db = new dblinqDataContext();
        private string FrontUrl = ConfigurationManager.AppSettings["FrontUrl"];
        private string ImageUrl = ConfigurationManager.AppSettings["ImageUrl"];
        private string ResizeImageUrl = ConfigurationManager.AppSettings["ResizeImageUrl"];
        private string bannersubcategoryImageResizeImage = ConfigurationManager.AppSettings["bannersubcategoryImageResizeImage"];
        private string Logosubcategory_ResizeImage = ConfigurationManager.AppSettings["Logosubcategory_ResizeImage"];
        private string servicesListing_ResizeImage = ConfigurationManager.AppSettings["servicesListing_ResizeImage"];
        private string servicesDetails_ResizeImage = ConfigurationManager.AppSettings["servicesDetails_ResizeImage"];
        private string ServicesGallery_ResizeImage = ConfigurationManager.AppSettings["ServicesGallery_ResizeImage"];
        private string ServicesDoctor_ResizeImage = ConfigurationManager.AppSettings["ServicesDoctor_ResizeImage"];



        public List<CategoryMenu> GetCategoryMenu()
        {
            return db.TreatmentCategories.Where(d => d.isPublished && !d.isDeleted).OrderByDescending(d => d.priority).ToList().Select(d => new CategoryMenu
            {
                id = d.id,
                title = d.title,
               SubcategoryMenu=db.TreatmentSubCategories.Where(x=> x.isPublished && !x.isDeleted && x.tcategoryId==d.id).OrderByDescending(x => x.priority).ToList().Select(x => new CategoryMenu
               {
                   id = x.id,
                   title = x.title,
                   link= FrontUrl+"services/" + Controllers.UtilsController.ReplaceSpecialChar(d.title)+"/" + Controllers.UtilsController.ReplaceSpecialChar(x.title),
               }).ToList(),
        }).ToList();
        }

        public servicesPage GetservicesPage(string category,string subcategory)
        {
            return db.TreatmentSubCategories.ToList().Where(d => d.isPublished && !d.isDeleted && Controllers.UtilsController.ReplaceSpecialChar(d.TreatmentCategory.title.ToLower())== category.ToLower() && Controllers.UtilsController.ReplaceSpecialChar(d.title.ToLower()) == subcategory.ToLower()).OrderByDescending(d => d.priority).Select(d => new servicesPage
            {
                id = d.id,
                title = d.title,
                smalldescription = d.description,
                bannerImage = d.imgSrc != "" ? ResizeImageUrl + bannersubcategoryImageResizeImage + Path.GetFileNameWithoutExtension(d.imgSrc) + ".webp" : null,

                LogoImage = d.logoSrc != "" ? ResizeImageUrl + Logosubcategory_ResizeImage + Path.GetFileNameWithoutExtension(d.logoSrc) + ".webp" : null,

                typeServices =db.TreatmentTypes.ToList().Where(x=>x.isPublished && !x.isDeleted && x.treatmentsubcatId==d.id).OrderByDescending(x => x.priority).Select(x => new typeServices
                {
                    id = x.id,
                    title = x.title,
                    servicesListing = x.Services.Where(z => z.isPublished && !z.isDeleted && z.tsubcategoryId == d.id && z.treatmentTypeId == x.id).OrderByDescending(z => z.priority).ToList().Select(z => new servicesListing
                    {
                        id = z.id,
                        title = z.title,
                        description = z.smallDescription,
                        image = z.imgSrc != "" ? ResizeImageUrl + servicesListing_ResizeImage + Path.GetFileNameWithoutExtension(z.imgSrc) + ".webp" : null,
                        link = FrontUrl + "service/" + Controllers.UtilsController.ReplaceSpecialChar(d.TreatmentCategory.title) + "/" + Controllers.UtilsController.ReplaceSpecialChar(d.title) + "/" + Controllers.UtilsController.ReplaceSpecialChar(x.title) + "/" + Controllers.UtilsController.ReplaceSpecialChar(z.title),
                    }).ToList(),
                }).ToList(),


            }).FirstOrDefault();
        }


         public servicesItem GetservicesItem(string subcategory, string typeItem,string name)
        {
            return db.Services.ToList().Where(d => d.isPublished && !d.isDeleted && Controllers.UtilsController.ReplaceSpecialChar(d.TreatmentSubCategory.title.ToLower())== subcategory.ToLower() && Controllers.UtilsController.ReplaceSpecialChar(d.TreatmentType.title.ToLower()) == typeItem.ToLower() && Controllers.UtilsController.ReplaceSpecialChar(d.title.ToLower()) == name.ToLower()).OrderByDescending(d => d.priority).Select(d => new servicesItem
            {
                id = d.id,
                title = d.title,
                smalldescription = d.description,
                bannerImage = d.bannerImgSrc != "" ? ResizeImageUrl + bannersubcategoryImageResizeImage + Path.GetFileNameWithoutExtension(d.bannerImgSrc) + ".webp" : null,

                LogoImage = d.TreatmentSubCategory.logoSrc != "" ? ResizeImageUrl + Logosubcategory_ResizeImage + Path.GetFileNameWithoutExtension(d.TreatmentSubCategory.logoSrc) + ".webp" : null,
                bookAppointmentLink="",
                consultationLink="",

                servicesDetails = d.ServicesRepeaters.ToList().Where(x=>x.isPublished && !x.isDeleted).OrderByDescending(x => x.priority).Select(x => new servicesDetails
                {
                    id = x.id,
                    title = x.title,
                    smalldescription=x.description,
                    Image= x.imgSrc != "" ? ResizeImageUrl + bannersubcategoryImageResizeImage + Path.GetFileNameWithoutExtension(x.imgSrc) + ".webp" : null,
                }).ToList(),


                treatabletitle = d.treatabletitle,
                treatabledescription = d.treatabledescription,
                servicesTreatableAreaItem = d.ServiceTreatableAreas.Where(x=> x.isPublished && !x.isDeleted).OrderByDescending(x=> x.priority).Select(x => new servicesTreatable
                {
                    id = x.id,
                    title = x.title,
                }).ToList(),

                servicesGalleryItem = d.ServicesGalleries.ToList().Where(x => x.isPublished && !x.isDeleted).OrderByDescending(x => x.priority).Select(x => new servicesGalleryItem
                {
                    beforeImage = x.beforeImgSrc != "" ? ResizeImageUrl + bannersubcategoryImageResizeImage + Path.GetFileNameWithoutExtension(x.beforeImgSrc) + ".webp" : null,
                    AfterImage = x.AfterImgSrc != "" ? ResizeImageUrl + bannersubcategoryImageResizeImage + Path.GetFileNameWithoutExtension(x.AfterImgSrc) + ".webp" : null,

                }).ToList(),

                servicesFAQItem = d.ServiceFaqs.ToList().Where(x => x.Faq.isPublished && !x.Faq.isDeleted).OrderByDescending(x => x.Faq.priority).Select(x => new servicesFAQ
                {
                    title = x.Faq.title,
                    description = x.Faq.description,

                }).ToList(),

                servicesDoctorItem = d.ServiceDoctors.ToList().Where(x => x.Doctor.isPublished && !x.Doctor.isDeleted).OrderByDescending(x => x.Doctor.priority).Select(x => new servicesDoctor
                {
                    title = x.Doctor.title,
                    position = x.Doctor.profenssion,
                    image = x.Doctor.imgSrc != "" ? ResizeImageUrl + bannersubcategoryImageResizeImage + Path.GetFileNameWithoutExtension(x.Doctor.imgSrc) + ".webp" : null,

                }).ToList(),

                servicesPackageItem = d.ServicePackages.ToList().Where(x => x.Package.isPublished && !x.Package.isDeleted).OrderByDescending(x => x.Package.priority).Select(x => new servicesPackage
                {
                    title = x.Package.title,
                    Price = x.Package.price,
                    SmallDescription = x.Package.smallDescription,
                    Link = x.Package.link

                }).ToList(),

            }).FirstOrDefault();
        }



    }
}