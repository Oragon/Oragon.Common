using System.Threading.Tasks;

namespace Oragon.Configuration
{
    public interface IConfigurationResolver
    {
        string GetConfiguration();

        Task<string> GetConfigurationAsync();
    }
}
