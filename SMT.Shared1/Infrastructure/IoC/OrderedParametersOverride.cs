using System;
using System.Collections.Generic;
using Unity.Builder;
using Unity.Injection;
using Unity.Policy;
using Unity.Resolution;

namespace SMT.Shared1.Infrastructure.IoC
{
    public class OrderedParametersOverride : ResolverOverride
    {
        #region Privte Fields
        /// <summary>
        /// The parameter values
        /// </summary>
        private readonly Queue<InjectionParameterValue> parameterValues;
        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderedParametersOverride" /> class.
        /// </summary>
        /// <param name="parameterValues">The parameter values.</param>
        public OrderedParametersOverride(IEnumerable<object> parameterValues)
        {
            if (parameterValues == null)
            {
                return;
            }

            this.parameterValues = new Queue<InjectionParameterValue>();
            foreach (var parameterValue in parameterValues)
            {
                this.parameterValues.Enqueue(InjectionParameterValue.ToParameter(parameterValue));
            }
        }

        public override IResolverPolicy GetResolver(IBuilderContext context, Type dependencyType)
        {
            if (this.parameterValues.Count < 1)
            {
                return null;
            }

            var value = this.parameterValues.Dequeue();
            return value.GetResolverPolicy(dependencyType);
        }

        #endregion
    }
}