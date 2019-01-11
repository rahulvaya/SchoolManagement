using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace SMT.Shared1.Infrastructure.IoC
{
    public interface IContainerInitializer
    {
        void Initialize(IUnityContainer unityContainer);
    }
}
