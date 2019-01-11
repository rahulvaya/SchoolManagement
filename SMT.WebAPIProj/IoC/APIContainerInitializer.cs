using SMT.Shared1.Infrastructure.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Unity;

namespace SMT.WebAPIProj.IoC
{
    public class APIContainerInitializer : IContainerInitializer
    {
        public void Initialize(IUnityContainer unityContainer)
        {
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(unityContainer);
        }
    }
}