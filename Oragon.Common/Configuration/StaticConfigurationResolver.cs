using System;
using System.Threading.Tasks;

namespace Oragon.Configuration
{
    public class StaticConfigurationResolver : ConfigurationResolverBase
    {
        public string Configuration { get; set; }

        public override string GetConfiguration()
        {
            return this.Configuration;
        }

    }
}
