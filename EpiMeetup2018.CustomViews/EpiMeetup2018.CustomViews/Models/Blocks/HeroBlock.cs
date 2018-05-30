using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;

namespace EpiMeetup2018.CustomViews.Models.Blocks
{
    [ContentType(DisplayName = "Hero Block", GUID = "970797e2-c929-4dce-b70d-862d2d881435", Description = "")]
    public class HeroBlock : BlockData
    {
        [Display(
            Name = "Image",
            GroupName = "Hero Image",
            Order = 100)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference HeroImage { get; set; }

        [Display(Name = "Hero Text",
            Description = "Text to display on top of the hero image",
            GroupName = "Hero Image",
            Order = 200)]
        public virtual string HeroText { get; set; }

        [Display(Name = "Hero Text Left Coordinate",
            Description = "Left coordinate for the hero text - set as a percentage but don't enter the percent sign",
            GroupName = "Hero Image",
            Order = 300)]
        public virtual int HeroTextLeftCoordinate { get; set; }


        [Display(Name = "Header Top Coordinate",
            Description = "Top coordinate for the header text - set as a percentage but don't enter the percent sign",
            GroupName = "Hero Image",
            Order = 400)]
        public virtual int HeroTextTopCoordinate { get; set; }

        [Ignore]
        public string ImageUrl
        {
            get
            {
                return !ContentReference.IsNullOrEmpty(HeroImage) ? ServiceLocator.Current.GetInstance<UrlResolver>().GetUrl(HeroImage) : string.Empty;
            }
        }
    }
}