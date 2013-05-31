using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Net.Http.Formatting;
using System.Web.Routing;

namespace Slalom.CustomAppDev.RecruitingManager.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            
            config.Routes.MapHttpRoute(
                name: "Web API Resource",
                routeTemplate: "Resources/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            /* Use the routes below if you want to use a mix RPC and RESTful approach for controllers
            // GET /api/{resource}/{action}/{id}
            config.Routes.MapHttpRoute(
                name: "Web API RPC",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { identifier = RouteParameter.Optional },
                constraints: new { action = @"[A-Za-z]+", httpMethod = new HttpMethodConstraint("GET") }
                );


            // GET|PUT|DELETE /api/{resource}/id
            config.Routes.MapHttpRoute(
                name: "Web API Resource",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { },
                constraints: new { id = @"\d+" }
                );

            // GET /api/{resource}
            config.Routes.MapHttpRoute(
                name: "Web API Get All",
                routeTemplate: "api/{controller}",
                defaults: new { action = "Get" },
                constraints: new { httpMethod = new HttpMethodConstraint("GET") }
                );

            // POST /api/{resource}
            config.Routes.MapHttpRoute(
                name: "Web API Post",
                routeTemplate: "api/{controller}",
                defaults: new { action = "Post" },
                constraints: new { httpMethod = new HttpMethodConstraint("POST") }
                );
            */
        }
    }
}
