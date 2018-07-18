// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Data.Common;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>BCD73DDC-D23E-4704-89BF-DD2796DA341C</id>
		/// <summary>
		///     Executes the query, and returns the first column of the first row in the result set returned by the query as a DateTime. Additional
		///     columns or rows are ignored.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>
		///     The date and time equivalent of the value of the first column of the first row in the result set. If the value equal DBNull.Value,
		///     throw an exception.
		/// </returns>
		public static DateTime ExecuteDateTime(this DbCommand @this)
		{
			return Convert.ToDateTime(@this.ExecuteScalar());
		}

		#endregion Public Methods
	}
}