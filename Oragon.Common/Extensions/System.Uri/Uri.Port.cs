using System;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		public static Uri Port(this Uri @this, int newPort)
		{
			var builder = new UriBuilder(@this);
			builder.Port = newPort;
			return builder.Uri;
		}

		#endregion Public Methods
	}
}