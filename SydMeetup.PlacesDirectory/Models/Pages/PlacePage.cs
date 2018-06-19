using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using SydMeetup.PlacesDirectory.Models.Blocks;
using System.ComponentModel.DataAnnotations;

namespace SydMeetup.PlacesDirectory.Models.Pages
{
    [ContentType(DisplayName = "Place", GUID = "dc8d93b8-817e-4feb-ad22-2b43485a3e4e", Description = "Place detail page")]
    [SiteImageUrl("~/Static/gfx/page-type-place.png")]
    public class PlacePage : SitePageData
    {
        [UIHint(UIHint.Textarea)]
        public virtual string Address { get; set; }

        public virtual XhtmlString Overview { get; set; }

        [AllowedTypes(typeof(MenuIItemBlock))]
        public virtual ContentArea MenuItems { get; set; }
    }
}