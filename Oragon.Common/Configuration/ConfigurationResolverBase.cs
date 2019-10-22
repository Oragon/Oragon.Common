using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Oragon.Configuration
{
    /// <summary>
    /// Base implementation for IConfigurationResolver
    /// </summary>
    /// <remarks>
    /// Override GetConfiguration() or GetConfigurationAsync(). 
    /// Does not implement anyone cause a circular reference and stack overflow
    /// </remarks>
    public abstract class ConfigurationResolverBase : IConfigurationResolver
    {
        public virtual string GetConfiguration() => this.GetConfigurationAsync().GetAwaiter().GetResult();

        public virtual Task<string> GetConfigurationAsync() => Task.FromResult(this.GetConfiguration());
    }
}
