using System.Web.Mvc;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using SydMeetup.PlacesDirectory.Business.Rendering;
using EPiServer.Web.Mvc;
using EPiServer.Web.Mvc.Html;
using EPiServer.ContentApi.Infrastructure;
using EPiServer.ContentApi.Search.Infrastructure;
using System.Web.Http;
using SydMeetup.PlacesDirectory.Infrastructure.WebApi;

namespace SydMeetup.PlacesDirectory.Business.Initialization
{
    [InitializableModule]
    public class DependencyResolverInitialization : IConfigurableModule
    {
        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            //Implementations for custom interfaces can be registered here.

            context.ConfigurationComplete += (o, e) =>
            {
                //Register custom implementations that should be used in favour of the default implementations
                context.Services.AddTransient<IContentRenderer, ErrorHandlingContentRenderer>()
                    .AddTransient<ContentAreaRenderer, CustomContentAreaRenderer>();
            };

            context.InitializeContentApi();
            context.InitializeContentSearchApi();

            GlobalConfiguration.Configure(config =>
            {
                //Other config settings may already be here, but ensure these are added:
                config.DependencyResolver = new StructureMapResolver(context.StructureMap());
                config.MapHttpAttributeRoutes();
                config.EnableCors();
            });
        }

        public void Initialize(InitializationEngine context)
        {
            DependencyResolver.SetResolver(new ServiceLocatorDependencyResolver(context.Locate.Advanced));
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        public void Preload(string[] parameters)
        {
        }
    }
}