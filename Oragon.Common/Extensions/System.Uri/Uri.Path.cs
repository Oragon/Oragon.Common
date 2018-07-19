using System;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		public static Uri Path(this Uri @this, string newPath)
		{
			var builder = new UriBuilder(@this);
			builder.Path = newPath;
			return builder.Uri;
		}

		#endregion Public Methods
	}
}