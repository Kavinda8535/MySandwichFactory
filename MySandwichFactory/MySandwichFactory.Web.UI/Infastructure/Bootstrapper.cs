using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using MySandwitchFactory.Business;
using MySandwitchFactory.Common;
using MySandwitchFactory.Portal.Common;

namespace MySandwitchFactory.Web.UI.Infastructure
{
    public class Bootstrapper
    {
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();
            DependencyResolver.SetResolver(new MyUnityDependancyResolver(container));
            return container;
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here 
            container.RegisterType<IFoodService, FoodService>();
            container.RegisterType<IFoodRepository, FoodRepository>();

            //RegisterTypes(container);
            return container;
            //throw new NotImplementedException();
        }

        private static void RegisterTypes(IUnityContainer container)
        {
            throw new NotImplementedException();
        }

        public static void DisposePerRequest(IDictionary contextItems)
        {
            var container = contextItems["perRequestContainer"] as IUnityContainer;
            if (container != null)
                container.Dispose();
        }
    }
}