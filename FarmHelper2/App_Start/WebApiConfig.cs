using FarmHelper2.Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace FarmHelper2
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            List<Planta> lista = Champ.best("Fertil", 30, 16,1);
            string str = Champ.bestOption(lista);

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
