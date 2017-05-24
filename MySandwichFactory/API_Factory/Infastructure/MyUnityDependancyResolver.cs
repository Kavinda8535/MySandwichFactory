﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;

namespace API_Factory.Infastructure
{
    public class MyUnityDependancyResolver : IDependencyResolver
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
    }
}