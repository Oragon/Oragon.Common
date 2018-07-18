// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Globalization;
using System.Text;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>19D78243-923C-43EE-AF24-BE7B6490DEDB</id>
		/// <summary>
		///     A string extension method that removes the diacritics character from the strings.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>The string without diacritics character</returns>
		public static string RemoveDiacritics(this string @this)
		{
			string normalizedString = @this.Normalize(NormalizationForm.FormD);
			var sb = new StringBuilder();

			foreach (char t in normalizedString)
			{
				UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(t);
				if (uc != UnicodeCategory.NonSpacingMark)
				{
					sb.Append(t);
				}
			}

			return sb.ToString().Normalize(NormalizationForm.FormC);
		}

		#endregion Public Methods
	}
}