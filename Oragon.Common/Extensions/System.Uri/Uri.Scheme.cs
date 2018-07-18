using System;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		public static Uri Scheme(this Uri @this, string newScheme)
		{
			var builder = new UriBuilder(@this);
			builder.Scheme = newScheme;
			return builder.Uri;
		}

		#endregion Public Methods
	}
}