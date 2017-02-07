using System;
using System.Web.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using Microsoft.Practices.Unity;
using DotNetLearningService.App_Start;
using DotNetLearningService.Repositories.Interfaces;
using DotNetLearningService.Repositories;

namespace DotNetLearningService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}", //"api/{controller}/{action}/{id}", //"api /{controller}/{id}",
                defaults: new {action = RouteParameter.Optional, id = RouteParameter.Optional }
            );

            config.Formatters.Add(new BrowserJsonFormatter());

            // Dependency Injecor Resolvers
            var container = new UnityContainer();

            container.RegisterType(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            container.RegisterType<ITechnologyTypeRepository, TechnologyTypeRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<ITechnologyLanguageRepository, TechnologyLanguageRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<ITechnologyConceptRepository, TechnologyConceptRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<ILanguageConceptRepository, LanguageConceptRepository>(new HierarchicalLifetimeManager());

            config.DependencyResolver = new UnityResolver(container);
        }
        
        public class BrowserJsonFormatter : JsonMediaTypeFormatter
        {
            public BrowserJsonFormatter()
            {
                this.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
                this.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
            }

            public override void SetDefaultContentHeaders(Type type, HttpContentHeaders headers, MediaTypeHeaderValue mediaType)
            {
                base.SetDefaultContentHeaders(type, headers, mediaType);
                headers.ContentType = new MediaTypeHeaderValue("application/json");
            }
        }
    }
}
