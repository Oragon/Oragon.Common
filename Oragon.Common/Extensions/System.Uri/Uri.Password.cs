using System;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		public static Uri Password(this Uri @this, string newPassword)
		{
			var builder = new UriBuilder(@this);
			builder.Password = newPassword;
			return builder.Uri;
		}

		#endregion Public Methods
	}
}