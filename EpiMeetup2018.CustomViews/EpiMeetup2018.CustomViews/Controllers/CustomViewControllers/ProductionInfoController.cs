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
    public class ProductionInfoController : Controller
    {
        public ActionResult Index()
        {
            // Since we're in an iFrame, need to do some manipulation to get the actual PageData object...
            var epiId = System.Web.HttpContext.Current.Request.QueryString["id"];
            var currentPage = ServiceLocator.Current.GetInstance<IContentRepository>().Get<ProductionDetailsPage>(new ContentReference(epiId));

            ProductionInfoViewModel viewModel = new ProductionInfoViewModel(currentPage);

            return View("~/Views/ProductionInfo.cshtml", viewModel);
        }
    }


    public class ProductionInfoViewModel
    {

        #region Properties
        public string Title { get; set; }
        public int ProductionID { get; set; }

        public string VenueName { get; set; }
        public IEnumerable<PerformanceData> Performances { get; set; }

        private string[] Ushers = { "Andrea", "Bob", "Christie", "David" };
        #endregion

        #region Constructors
        public ProductionInfoViewModel(ProductionDetailsPage demoPage)
        {
            this.Title = demoPage.Name;
            this.ProductionID = demoPage.ContentLink.ID;

            this.VenueName = "Memorial Playhouse";

            this.Performances = GetPerformanceData(this.ProductionID);
        }
        #endregion

        private IEnumerable<PerformanceData> GetPerformanceData(int productionID)
        {
            // Here is the part where you would call your external API...
            List<DateTime> perfDates = new List<DateTime>();


            var todayAtSix = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 18, 0, 0);
            perfDates.Add(todayAtSix);

            for(int i=0;i<4;i++)
            {
                perfDates.Add(todayAtSix.AddDays(i));
            }

            var random = new Random();
            return perfDates.Select(date => new PerformanceData() { StartTime = date, TicketsRemaining = random.Next(0,100), Usher = Ushers[random.Next(0,3)] });
        }
    }

    public struct PerformanceData
    {
        public DateTime StartTime;
        public int TicketsRemaining;
        public string Usher;
    }
}