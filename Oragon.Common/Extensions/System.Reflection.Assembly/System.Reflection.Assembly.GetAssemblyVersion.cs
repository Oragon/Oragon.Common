using System.Reflection;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		public static string GetAssemblyVersion(this System.Reflection.Assembly @this)
		{
			AssemblyVersionAttribute attr = @this.GetCustomAttribute<AssemblyVersionAttribute>();
			string returnValue = null;
			if (attr != null)
				returnValue = attr.Version;
			return returnValue;
		}

		#endregion Public Methods
	}
}