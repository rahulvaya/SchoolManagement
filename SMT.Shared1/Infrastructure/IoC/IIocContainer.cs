using System;
using System.Collections.Generic;
using System.Text;

namespace SMT.Shared1.Infrastructure.IoC
{
    public interface IIocContainer : IDisposable
    {
        IServiceLocator GetServiceLocator();

        IIocContainer CreateChildContainer();
    }
}
