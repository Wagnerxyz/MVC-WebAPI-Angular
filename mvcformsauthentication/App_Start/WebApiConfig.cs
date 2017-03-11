using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using mvcformsauthentication.Models;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace mvcformsauthentication
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

          
        }
    }
}
