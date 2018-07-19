using System;
using System.Linq;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		public static System.Type GetUniqueAndExpectedInputParameterType(this System.Reflection.MethodInfo methodInfo)
		{
			Type inType = null;
			try
			{
				inType = methodInfo.GetParameters().Single().ParameterType;
			}
			catch (Exception ex)
			{
				throw new InvalidOperationException(string.Format("Error during get MessageInputParameterType for method {0} ", methodInfo.Name), ex);
			}
			return inType;
		}

		#endregion Public Methods
	}
}