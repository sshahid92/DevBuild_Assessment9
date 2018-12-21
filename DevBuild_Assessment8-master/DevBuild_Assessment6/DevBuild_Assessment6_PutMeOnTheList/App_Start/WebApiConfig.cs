using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace DevBuild_Assessment6_PutMeOnTheList
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var jsonSerializerSettings =
                config.Formatters.JsonFormatter.SerializerSettings;
            jsonSerializerSettings.ReferenceLoopHandling =
                Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            jsonSerializerSettings.ContractResolver =
                new CamelCasePropertyNamesContractResolver();

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
