using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace SydMeetup.PlacesDirectory.Models.Blocks
{
    [ContentType(DisplayName = "MenuIItemBlock", GUID = "35e68c8d-6e1c-4041-8ba0-6b2aa643e221", Description = "")]
    [SiteImageUrl("~/Static/gfx/block-type-generic.png")]
    public class MenuIItemBlock : SiteBlockData
    {
        [UIHint(UIHint.Textarea)]
        public virtual string Description { get; set; }

        public virtual double Price { get; set; }
    }
}