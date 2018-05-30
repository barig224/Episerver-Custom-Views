using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EpiMeetup2018.CustomViews.Controllers.CustomViewControllers
{
    public class OGImageController : Controller
    {
        public ActionResult Index(ContentReference ogImage)
        {
            // Note that this is pretty inefficient and really should be refactored for performance

            var mediaData = ServiceLocator.Current.GetInstance<IContentRepository>().Get<MediaData>(ogImage);

            OGImageViewModel viewModel = new OGImageViewModel();
            viewModel.Url = UrlResolver.Current.GetUrl(ogImage);

            using (var stream = mediaData.BinaryData.OpenRead())
            {
                var image = Image.FromStream(stream);

                viewModel.Height = image.Height;
                viewModel.Width = image.Width;
                viewModel.FileSize = (stream.Length / 1024f) / 1024f;
            }

            return View("~/Views/OGImage.cshtml", viewModel);
        }
    }

    public struct OGImageViewModel
    {
        public string Url;
        public int Height;
        public int Width;
        public double FileSize;
    }
}