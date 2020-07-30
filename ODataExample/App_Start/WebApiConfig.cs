using Autofac;
using Autofac.Integration.WebApi;
using ODataExample.Controllers;
using ODataExample.EF;
using ODataExample.Registers;
using ODataExample.Repository;
using System.Collections.Generic;
using System.Reflection;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;

namespace ODataExample
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Web API routes
            config.MapHttpAttributeRoutes();

           config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
           
            ODataRegisterBuilder.Register(config);

            AutofacRegisterBuilder.Register(config);

            config.Services.Replace(typeof(IHttpControllerSelector), new ODataHttpControllerSelector(config));

        }
    }
}
