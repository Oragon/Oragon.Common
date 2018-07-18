// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Data;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>42ACF5FE-402B-4B66-9F97-CFFF04CBF09C</id>
		/// <summary>
		///     A DataColumnCollection extension method that adds a range of columns with the specified values.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <param name="values">A variable-length parameters list containing values.</param>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0")]
		public static void AddRange(this DataColumnCollection @this, params string[] values)
		{
			foreach (string value in values)
			{
				@this.Add(value);
			}
		}

		#endregion Public Methods
	}
}