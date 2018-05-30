using EpiMeetup2018.CustomViews.Models.Pages;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Shell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiMeetup2018.CustomViews.Business
{
    [ServiceConfiguration(typeof(EPiServer.Shell.ViewConfiguration))]
    public class ProductionInfoViewConfig : ViewConfiguration<ProductionDetailsPage>
    {
        public ProductionInfoViewConfig()
        {
            Key = "prodInfo";
            Name = "Production Information";
            Description = "Info from external system about this particular production";
            ControllerType = "epi-cms/widget/IFrameController";
            ViewType = "/ProductionInfo/";
            IconClass = "prodInfo";
        }
    }

    [ServiceConfiguration(typeof(EPiServer.Shell.ViewConfiguration))]
    public class AboutThisPageTypeViewConfig : ViewConfiguration<ProductionDetailsPage>
    {
        public AboutThisPageTypeViewConfig()
        {
            Key = "aboutThisPage";
            Name = "About This Page Type";
            Description = "Info about this page type";
            ControllerType = "epi-cms/widget/IFrameController";
            ViewType = "/AboutThisPageType/";
            IconClass = "aboutThisPageType";
        }
    }

    [ServiceConfiguration(typeof(EPiServer.Shell.ViewConfiguration))]
    public class SEOPropertyViewConfig : ViewConfiguration<PageData>
    {
        public SEOPropertyViewConfig()
        {
            Key = "seoProperty";
            Name = "SEO Properties";
            Description = "In-depth explanation of SEO Properites";
            ControllerType = "epi-cms/widget/IFrameController";
            ViewType = "/SEOProperties/";
            IconClass = "seoProperties";
        }
    }

    [ServiceConfiguration(typeof(EPiServer.Shell.ViewConfiguration))]
    public class HeroEditorViewConfig : ViewConfiguration<ProductionDetailsPage>
    {
        public HeroEditorViewConfig()
        {
            Key = "heroEditor";
            Name = "Hero Editor";
            Description = "Interactive editing view for the Hero image";
            ControllerType = "epi-cms/widget/IFrameController";
            ViewType = "/HeroEditor/";
            IconClass = "heroEditor";
        }
    }
}