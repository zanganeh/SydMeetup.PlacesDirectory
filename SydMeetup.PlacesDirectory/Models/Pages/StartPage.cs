using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace SydMeetup.PlacesDirectory.Models.Pages
{
    [ContentType(DisplayName = "Start Page", GUID = "490a23d1-c3cd-4c73-a219-8610883fb8dc", Description = "")]
    [SiteImageUrl("~/Static/gfx/page-type-start.png")]
    public class StartPage : SitePageData
    {
        public virtual string GoogleApiKey { get; set; }
    }
}