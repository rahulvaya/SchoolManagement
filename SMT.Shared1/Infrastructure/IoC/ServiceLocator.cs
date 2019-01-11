using SMT.Shared1.Infrastructure.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Resolution;

namespace SMT.Shared1.Infrastructure.IoC
{
    public class ServiceLocator : IServiceLocator
    {
        /// <summary>
        /// The container
        /// </summary>
        private IUnityContainer container;

        public ServiceLocator()
        {
        }


        /// <summary>
        /// Sets the container.
        /// </summary>
        /// <param name="unityContainer">The container.</param>
        public void SetContainer(IUnityContainer unityContainer)
        {
            this.container = (UnityContainer)unityContainer;
        }

        /// <summary>
        /// Resolves the specified type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>
        /// The System.Object.
        /// </returns>
        public object Resolve(Type type)
        {
            return this.container.Resolve(type);
        }

        /// <summary>
        /// Resolves the specified type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="name">The name.</param>
        /// <returns>
        /// The System.Object.
        /// </returns>
        public object Resolve(Type type, string name)
        {
            return this.container.Resolve(type, name);
        }

        /// <summary>
        /// Resolves this instance.
        /// </summary>
        /// <typeparam name="T">The Generic Type.</typeparam>
        /// <returns>
        /// The T.
        /// </returns>
        public T Resolve<T>()
        {
            return this.container.Resolve<T>();
        }

        /// <summary>
        /// Resolves the specified name.
        /// </summary>
        /// <typeparam name="T">The Generic Type.</typeparam>
        /// <param name="name">The name.</param>
        /// <returns>
        /// The T.
        /// </returns>
        public T Resolve<T>(string name)
        {
            return this.container.Resolve<T>(name);
        }

        public T Resolve<T>(object[] parameters)
        {
            return this.container.Resolve<T>(new OrderedParametersOverride(parameters));
        }

        public T Resolve<T>(string name, object[] parameters)
        {
            return this.container.Resolve<T>(name, new OrderedParametersOverride(parameters));
        }


        public IEnumerable<T> ResolveAll<T>()
        {
            return this.container.ResolveAll<T>();
        }


        public T Resolve<T>(IDictionary<string, object> parameters)
        {
            var partialParameters = new List<ResolverOverride>();

            foreach (var param in parameters)
            {
                partialParameters.Add(new ParameterOverride(param.Key, param.Value));
            }

            return this.container.Resolve<T>(partialParameters.ToArray());
        }


        public bool IsRegistered(Type type)
        {
            return this.container.IsRegistered(type);
        }
    }
}
