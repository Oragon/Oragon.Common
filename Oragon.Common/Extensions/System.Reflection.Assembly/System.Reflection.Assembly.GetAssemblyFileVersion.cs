using System.Reflection;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		public static string GetAssemblyFileVersion(this System.Reflection.Assembly @this)
		{
			AssemblyFileVersionAttribute attr = @this.GetCustomAttribute<AssemblyFileVersionAttribute>();
			string returnValue = null;
			if (attr != null)
				returnValue = attr.Version;
			return returnValue;
		}

		#endregion Public Methods
	}
}