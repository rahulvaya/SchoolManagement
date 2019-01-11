using SMT.Shared1.Infrastructure.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMT.WebAPIProj.IoC
{
    public class UnityHttpPerRequestLifetimeManager : UnityPerRequestLifetimeManager
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnityHttpPerRequestLifetimeManager"/> class
        /// </summary>
        public UnityHttpPerRequestLifetimeManager()
            : base(new HttpRequestStore())
        {
        }
    }
}