using System.Web.Mvc;
using Microsoft.Practices.Unity;
using MySandwitchFactory.Business;
using MySandwitchFactory.Web.UI.Infastructure;
using MySandwitchFactory.Web.UI.Services;

namespace MySandwitchFactory.Web.UI.App_Start
{
    public static class IocConfiguration
    {
        public static void ConfigureIocUnityContaioner()
        {
            IUnityContainer container = new UnityContainer();

            RegisterServices(container);

            DependencyResolver.SetResolver(new MyUnityDependancyResolver(container));
        }

        private static void RegisterServices(IUnityContainer container)
        {
            container.RegisterType<ILocalWeaherServiceProvider, LocalWeatherServiceProvider>(); // This means when somebody call/need ILocalWeaherServiceProvider then provide new Instance of the LocalWeatherServiceProvider
            container.RegisterType<IFacebookConnectionManager, FacebookConnectionManager>(new InjectionConstructor(
                System.Configuration.ConfigurationManager.AppSettings["userName"],
                System.Configuration.ConfigurationManager.AppSettings["authenticationToken"],
                System.Configuration.ConfigurationManager.AppSettings["faceBookAuthUrl"]
                ));

            container.RegisterType<IFoodService, FoodService>();

        }
    }
}