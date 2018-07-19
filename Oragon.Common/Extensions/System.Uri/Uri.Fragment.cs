using System;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		public static Uri Fragment(this Uri @this, string newFragment)
		{
			var builder = new UriBuilder(@this);
			builder.Fragment = newFragment;
			return builder.Uri;
		}

		#endregion Public Methods
	}
}