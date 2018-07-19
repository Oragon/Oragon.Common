using System;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		public static Uri Query(this Uri @this, string newQuery)
		{
			var builder = new UriBuilder(@this);
			builder.Path = newQuery;
			return builder.Uri;
		}

		#endregion Public Methods
	}
}