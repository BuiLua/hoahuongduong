using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace FirstDatabaseProject.App_Start
{
    public class WebApiConfig
    {
        /// <summary>
        /// phương thức config cho api
        /// </summary>
        /// <param name="config"></param>
        public static void RegisterRoutes(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/id",
                defaults: new { controller = "APIHome", action = "Index", id = RouteParameter.Optional }
            );
        }
    }
}