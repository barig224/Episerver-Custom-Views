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
    public class AboutThisPageTypeController : Controller
    {
        public ActionResult Index()
        {
            // Since we're in an iFrame, need to do some manipulation to get the actual PageData object...
            var epiId = System.Web.HttpContext.Current.Request.QueryString["id"];
            var currentPage = ServiceLocator.Current.GetInstance<IContentRepository>().Get<ProductionDetailsPage>(new ContentReference(epiId));

            return View("~/Views/AboutThisPageType.cshtml", currentPage);
        }
    }
}