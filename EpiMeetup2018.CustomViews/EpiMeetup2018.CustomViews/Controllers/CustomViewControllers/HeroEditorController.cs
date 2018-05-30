using EpiMeetup2018.CustomViews.Models.Pages;
using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EpiMeetup2018.CustomViews.Controllers.CustomViewControllers
{
    public class HeroEditorController : Controller
    {
        public ActionResult Index()
        {
            // Since we're in an iFrame, need to do some manipulation to get the actual PageData object...
            var epiId = System.Web.HttpContext.Current.Request.QueryString["id"];
            return GetViewForId(epiId, false);
        }
        public ActionResult GetViewForId(string id, bool changed)
        {
            var currentPage = ServiceLocator.Current.GetInstance<IContentRepository>().Get<ProductionDetailsPage>(new ContentReference(id));

            // Going to cheat a little bit and use ViewData...shhhh....
            if (changed)
            {
                ViewData["changed"] = "true";
            }

            return View("~/Views/HeroEditor.cshtml", currentPage);
        }


        [HttpPost]
        public ActionResult UpdateHero()
        {
            var headerLeft = Request.Form["headerLeft"];
            var headerTop = Request.Form["headerTop"];


            var epiID = Request.Form["ContentLink.ID"];

            var contentRepo = ServiceLocator.Current.GetInstance<IContentRepository>();

            var pageData = contentRepo.Get<ProductionDetailsPage>(new ContentReference(epiID));
            var changed = false;

            if (pageData != null)
            {
                var clone = pageData.CreateWritableClone() as ProductionDetailsPage;
                clone.Hero.HeroTextLeftCoordinate = int.Parse(headerLeft);
                clone.Hero.HeroTextTopCoordinate = int.Parse(headerTop);

                contentRepo.Save(clone, EPiServer.DataAccess.SaveAction.Publish, EPiServer.Security.AccessLevel.NoAccess);

                changed = true;
            }

            return RedirectToAction("GetViewForId", new { id = epiID, changed = changed });
        }
    }
}