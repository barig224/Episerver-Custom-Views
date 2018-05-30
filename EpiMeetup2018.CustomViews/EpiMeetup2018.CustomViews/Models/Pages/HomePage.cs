using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiMeetup2018.CustomViews.Models.Pages
{
    [ContentType(DisplayName = "Home Page", GUID = "b9bdc0ff-c8a3-4dfb-90d3-ee1ae9aafa6b", Description = "")]
    public class HomePage : SEOPageBase
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

    }
}