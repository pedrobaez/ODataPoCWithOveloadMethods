using Autofac;
using Autofac.Integration.WebApi;
using ODataExample.Repository;
using ODataExample.Repository.AddressRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace ODataExample.Registers
{
    public static class AutofacRegisterBuilder
    {
        public static void Register(HttpConfiguration config)
        {
            ContainerBuilder IoCBuilder = new ContainerBuilder();
            IoCBuilder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            IoCBuilder.RegisterType<ShiftRepository>().AsImplementedInterfaces().SingleInstance();
            IoCBuilder.RegisterType<AddressRepository>().AsImplementedInterfaces().SingleInstance();

            IContainer container = IoCBuilder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}