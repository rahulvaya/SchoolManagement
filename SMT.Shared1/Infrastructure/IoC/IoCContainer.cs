using Microsoft.Practices.Unity.Configuration;
using SMT.Shared1.Infrastructure.Common.Constants;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Unity;

namespace SMT.Shared1.Infrastructure.IoC
{
    public class IoCContainer : IIocContainer
    {

        private static readonly Lazy<IoCContainer> LazyInstance = new Lazy<IoCContainer>(() => new IoCContainer());

        private bool isInitialized = false;

        private IUnityContainer unityContainer;
        protected IoCContainer()
        {
            this.unityContainer = new UnityContainer();
        }

        protected IoCContainer(IUnityContainer unityContainer)
        {
            this.unityContainer = unityContainer;
        }

        public static IoCContainer Instance
        {
            get { return LazyInstance.Value; }
        }

        public static bool IsInitialized
        {
            get
            {
                return LazyInstance.IsValueCreated;
            }

            private set
            {
            }
        }

        public void Initialize()
        {
            if (!this.isInitialized)
            {
                UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection(UnityConfigurationSection.SectionName);
                section.Configure(this.unityContainer, "MainContainer");

                var serviceLocator = this.unityContainer.Resolve<IServiceLocator>();
                serviceLocator.SetContainer(this.unityContainer);

                this.isInitialized = true;
            }
        }

        public void Initialize(IContainerInitializer initializer)
        {
            this.Initialize();
            initializer.Initialize(this.unityContainer);
        }

        public IServiceLocator GetServiceLocator()
        {
            return this.unityContainer.Resolve<IServiceLocator>();
        }

        public IIocContainer CreateChildContainer()
        {
            var childContainer = this.unityContainer.CreateChildContainer();
            var locator = childContainer.Resolve<IServiceLocator>();
            locator.SetContainer(childContainer);
            return new IoCContainer(childContainer);
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.unityContainer != null)
                {
                    this.unityContainer.Dispose();
                }
            }
        }
    }
}
