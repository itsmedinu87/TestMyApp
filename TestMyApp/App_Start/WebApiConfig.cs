using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TestMyApp.Business.Interface;
using TestMyApp.Business.Services;
using TestMyApp.Data.Interface;
using TestMyApp.Data.Repositories;
using Unity;
using Unity.WebApi;

namespace TestMyApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            var container = new UnityContainer();
            container.RegisterType<IMessageService, MessageService>();
            container.RegisterType<IMessageRepository, MessageRepository>();

            config.DependencyResolver = new UnityDependencyResolver(container);

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
