using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Lifetime;

namespace SMT.Shared1.Infrastructure.IoC
{
    public class UnityPerRequestLifetimeManager : LifetimeManager, IDisposable
    {
        /// <summary>
        /// Holds the key for the item to be stored in the session.
        /// </summary>
        private readonly string key = Guid.NewGuid().ToString();

        /// <summary>The context store.</summary>
        private IPerRequestStore contextStore;

        /// <summary>
        /// Decides whether current instance has been disposed or not.
        /// </summary>
        private bool disposed;

        /// <summary>Initializes a new instance of the <see cref="UnityPerRequestLifetimeManager"/> class</summary>
        /// <param name="perRequestStore">The per request store.</param>
        public UnityPerRequestLifetimeManager(IPerRequestStore perRequestStore)
        {
            this.contextStore = perRequestStore;
        }

        /// <summary>
        /// Retrieve a value from the backing store associated with this Lifetime policy.
        /// </summary>
        /// <returns>The object desired, or null if no such object is currently stored.</returns>
        public object GetValue()
        {
            return this.contextStore.GetValue(this.key);
        }

        /// <summary>
        /// Remove the given object from backing store.
        /// </summary>
        public void RemoveValue()
        {
            var storedObject = this.contextStore.GetValue(this.key);
            this.contextStore.RemoveValue(this.key);

            var disposable = storedObject as IDisposable;
            if (disposable != null)
            {
                disposable.Dispose();
            }
        }

        /// <summary>
        /// Stores the given value into backing store for retrieval later.
        /// </summary>
        /// <param name="newValue">The object being stored.</param>
        public void SetValue(object newValue)
        {
            this.contextStore.SetValue(this.key, newValue);
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.RemoveValue();
                }
            }

            this.disposed = true;
        }

        public override object GetValue(ILifetimeContainer container = null)
        {
            throw new NotImplementedException();
        }

        protected override LifetimeManager OnCreateLifetimeManager()
        {
            throw new NotImplementedException();
        }
    }
}
