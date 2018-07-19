using System;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		public static Uri Host(this Uri @this, string newHost)
		{
			var builder = new UriBuilder(@this);
			builder.Host = newHost;
			return builder.Uri;
		}

		#endregion Public Methods
	}
}