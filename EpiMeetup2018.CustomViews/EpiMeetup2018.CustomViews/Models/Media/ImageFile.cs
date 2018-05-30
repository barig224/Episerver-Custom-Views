using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace EpiMeetup2018.CustomViews.Models.Media
{
    [ContentType(DisplayName = "ImageFile", GUID = "63ad7d77-698b-4841-ab14-a7bba27e4bd8", Description = "")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,ico,gif,bmp,png")]
    public class ImageFile : ImageData
    {
        [Display(Name = "Alt Text", Order = 100)]
        public virtual string AltText { get; set; }

        [Display(Name = "Gallery Caption", Order = 200)]
        public virtual string GalleryCaption { get; set; }
    }
}