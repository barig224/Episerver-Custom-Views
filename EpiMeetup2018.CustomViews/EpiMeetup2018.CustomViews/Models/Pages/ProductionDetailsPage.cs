using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EpiMeetup2018.CustomViews.Models.Blocks;

namespace EpiMeetup2018.CustomViews.Models.Pages
{
    [ContentType(DisplayName = "Production Details Page", GUID = "6a7d43c2-46c0-4929-b77a-a71fcbc5cd5d", Description = "")]
    public class ProductionDetailsPage : SEOPageBase
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual string Title { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual HeroBlock Hero { get; set; }

        [Display(
            Name = "Content Area",
            Description = "Area to host blocks on the page.",
            GroupName = SystemTabNames.Content,
            Order = 300)]
        public virtual ContentArea ContentArea { get; set; }
    }
}