using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using Unity;
using TUIBackEnd.BLL;
using Unity.Lifetime;
using TUIBackEnd.Web.ResolverDI;

namespace TUIBackEnd.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            //DI
            // Web API configuration and services
            var container = new UnityContainer();

            container.RegisterType<ICountryBLL, CountryBLL>(new HierarchicalLifetimeManager());            

            container.RegisterType<IFlightBLL, FlightBLL>(new HierarchicalLifetimeManager());            

            container.RegisterType<IAirportBLL, AirportBLL>(new HierarchicalLifetimeManager());

            config.DependencyResolver = new UnityResolver(container);


            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

          
            
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        
    }
}
