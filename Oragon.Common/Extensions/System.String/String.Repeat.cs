// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Text;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>8064BDCB-B453-48D0-B483-29C69766C842</id>
		/// <summary>
		///     A string extension method that repeats.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <param name="repeatCount">Number of repeats.</param>
		/// <returns>The repeated string.</returns>
		/// <example><code> var s = "test".Repeat(3); </code></example>
		public static string Repeat(this string @this, int repeatCount)
		{
			if (@this.Length == 1)
			{
				return new string(@this[0], repeatCount);
			}

			var sb = new StringBuilder(repeatCount * @this.Length);
			while (repeatCount-- > 0)
			{
				sb.Append(@this);
			}

			return sb.ToString();
		}

		#endregion Public Methods
	}
}