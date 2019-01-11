using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace SMT.Shared1.Infrastructure.IoC
{
    public interface IServiceLocator
    {
        void SetContainer(IUnityContainer unityContainer);


        object Resolve(Type type);


        object Resolve(Type type, string name);


        T Resolve<T>();


        T Resolve<T>(string name);


        IEnumerable<T> ResolveAll<T>();


        T Resolve<T>(string name, object[] parameters);


        T Resolve<T>(object[] parameters);


        T Resolve<T>(IDictionary<string, object> parameters);

        bool IsRegistered(Type type);
    }
}
