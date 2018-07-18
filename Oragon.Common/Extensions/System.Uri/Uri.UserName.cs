using System;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		public static Uri UserName(this Uri @this, string newUserName)
		{
			var builder = new UriBuilder(@this);
			builder.UserName = newUserName;
			return builder.Uri;
		}

		#endregion Public Methods
	}
}