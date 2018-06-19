using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using System.Web.Optimization;

namespace SydMeetup.PlacesDirectory.Business.Initialization
{
    [InitializableModule]
    public class BundleConfig : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            if (context.HostType == HostType.WebApplication)
            {
                RegisterBundles(BundleTable.Bundles);
            }
        }

        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles
                .Add(new ScriptBundle("~/bundles/googlemap-js", "https://maps.googleapis.com/maps/api/js?key=AIzaSyDk9KNSL1jTv4MY9Pza6w8DJkpI_nHyCnk")
                .Include("~/Static/js/google-map/location-map-active.js"));

            bundles
                .Add(new ScriptBundle("~/bundles/js").Include(
                        "~/Static/js/jquery/jquery-2.2.4.min.js",
                        "~/Static/js/bootstrap/popper.min.js",
                        "~/Static/js/bootstrap/bootstrap.min.js",
                        "~/Static/js/others/plugins.js",
                        "~/Static/js/active.js"));

            bundles.Add(new StyleBundle("~/bundles/css")
                .Include("~/Static/css/style.css")
                .Include("~/Static/css/responsive/responsive.css"));
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        public void Preload(string[] parameters)
        {
        }
    }
}