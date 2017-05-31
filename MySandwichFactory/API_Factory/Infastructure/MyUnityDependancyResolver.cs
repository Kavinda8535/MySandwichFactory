using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;
using Microsoft.Practices.Unity;
using IDependencyResolver = System.Web.Mvc.IDependencyResolver;

namespace API_Factory.Infastructure
{
    public class MyUnityDependancyResolver :  IDependencyResolver, System.Web.Http.Dependencies.IDependencyResolver
    {
        private IUnityContainer _unityContainer;

        public MyUnityDependancyResolver(IUnityContainer unityContainer)
        {
            _unityContainer = unityContainer;
        }


        public object GetService(Type serviceType)
        {
            try
            {
                return _unityContainer.Resolve(serviceType);
            }
            catch (Exception)
            {

                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return _unityContainer.ResolveAll(serviceType);
            }
            catch (Exception)
            {

                return new List<object>();
            }
        }

        public IDependencyScope BeginScope()
        {
            var child = _unityContainer.CreateChildContainer();
            return new MyUnityDependancyResolver(child);
        }

        public void Dispose()
        {
            _unityContainer.Dispose();
        }
    }
}