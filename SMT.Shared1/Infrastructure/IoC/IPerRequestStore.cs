using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMT.Shared1.Infrastructure.IoC
{
    public interface IPerRequestStore
    {
        object GetValue(string key);

        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        void SetValue(string key, object value);

        /// <summary>
        /// Removes the value.
        /// </summary>
        /// <param name="key">The key.</param>
        void RemoveValue(string key);
    }
}
