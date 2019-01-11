using SMT.Shared1.Infrastructure.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMT.WebAPIProj.IoC
{
    public class HttpRequestStore : IPerRequestStore
    {
        /// <summary>represent GetValue.</summary>
        /// <param name="key">The key.</param>
        /// <returns>The value.</returns>
        public object GetValue(string key)
        {
            if (HttpContext.Current.Items.Count > 0 && !string.IsNullOrWhiteSpace(key))
            {
                return HttpContext.Current.Items[key];
            }
            else
            {
                return null;
            }
        }

        /// <summary>represent SetValue.</summary>
        /// <param name="key"> The key .</param>
        /// <param name="value">The value.</param>
        public void SetValue(string key, object value)
        {
            HttpContext.Current.Items[key] = value;
        }

        /// <summary>represent RemoveValue.</summary>
        /// <param name="key">The key.</param>
        public void RemoveValue(string key)
        {
            HttpContext.Current.Items.Remove(key);
        }
    }
}