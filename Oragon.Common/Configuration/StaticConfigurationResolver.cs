using System;
using System.Threading.Tasks;

namespace Oragon.Configuration
{
    public class StaticConfigurationResolver : IConfigurationResolver
    {
        public string Configuration { get; set; }

        public string GetConfiguration()
        {
            return this.Configuration;
        }

        public Task<string> GetConfigurationAsync()
        {
            return Task.FromResult(this.GetConfiguration());
        }
    }
}
