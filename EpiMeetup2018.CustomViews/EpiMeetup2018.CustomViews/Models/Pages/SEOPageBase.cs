using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace EpiMeetup2018.CustomViews.Models.Pages
{
    [ContentType(DisplayName = "SEOPageBase", GUID = "14903436-3d22-4965-8036-3981690c5414", Description = "")]
    public abstract class SEOPageBase : PageData
    {
        [CultureSpecific]
        [Display(
            Name = "SEO Title",
            Description = "The title of the page",
            GroupName = "SEO",
            Order = 1000)]
        public virtual string SEOTitle { get; set; }


        [CultureSpecific]
        [UIHint(UIHint.Image)]
        [Display(Name = "OG:Image",
            Description = "Image that will be value of og:image tag",
            GroupName = "SEO",
            Order = 7000)]
        public virtual ContentReference OGImage { get; set; }
    }
}