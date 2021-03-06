﻿using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Wissen.Data;
using Wissen.Service;

namespace Wissen.Admin
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var builder = new ContainerBuilder();

            // Register your MVC controllers. (MvcApplication is the name of
            // the class in Global.asax.)
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // OPTIONAL: Register model binders that require DI.
            builder.RegisterModelBinders(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinderProvider();

            // OPTIONAL: Register web abstractions like HttpContextBase.
            builder.RegisterModule<AutofacWebTypesModule>();

            // OPTIONAL: Enable property injection in view pages.
            builder.RegisterSource(new ViewRegistrationSource());

            // OPTIONAL: Enable property injection into action filters.
            builder.RegisterFilterProvider();

<<<<<<< HEAD
            //db context'i mi scoped(yani request bazlı)olarak register et
            builder.RegisterType<ApplicationDbContext>().InstancePerRequest();

            //generic repository geçici (transient) instance olarak register et
            //generic repositorynın calısmasi için
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).InstancePerDependency();

            //servisleri register et
=======
            // db context'imi scoped (yani request bazlı) olarak register et
            builder.RegisterType<ApplicationDbContext>().InstancePerRequest();

            // generic repository'i geçici (transient) instance olarak register et
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).InstancePerDependency();

            // servisleri register et
>>>>>>> ea864b23c481a57cccfc58da7afa2b708e1a67f6
            builder.RegisterType(typeof(PostService)).As(typeof(IPostService)).InstancePerDependency();
            builder.RegisterType(typeof(CategoryService)).As(typeof(ICategoryService)).InstancePerDependency();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
