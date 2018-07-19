using System;

namespace Oragon.Configuration
{
    public class StaticConfigurationResolver : IConfigurationResolver
    {
        public string Configuration { get; set; }

        public string GetConfiguration()
        {
            return this.Configuration;
        }
    }
}
