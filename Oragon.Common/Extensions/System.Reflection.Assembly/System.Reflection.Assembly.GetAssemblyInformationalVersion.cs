using System.Reflection;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		public static string GetAssemblyInformationalVersion(this System.Reflection.Assembly @this)
		{
			AssemblyInformationalVersionAttribute attr = @this.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
			string returnValue = null;
			if (attr != null)
				returnValue = attr.InformationalVersion;
			return returnValue;
		}

		#endregion Public Methods
	}
}