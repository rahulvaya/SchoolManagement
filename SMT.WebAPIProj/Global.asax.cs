using SMT.Shared1.Infrastructure.IoC;
using SMT.WebAPIProj.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using SMT.DataAccess;
using SMT.Entities;

namespace SMT.WebAPIProj
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        private APIContainerInitializer containerInitializer;

        protected void Application_Start()
        {
            this.containerInitializer = new APIContainerInitializer();
            IoCContainer.Instance.Initialize(this.containerInitializer);
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
