// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Data.Common;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>EB25EAB5-E9C9-411B-8F25-03680A4F3B3C</id>
		/// <summary>
		///     Executes the query, and returns the first column of the first row in the result set returned by the query as a Boolean. Additional
		///     columns or rows are ignored.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>
		///     true or false, which reflects the value returned by invoking the IConvertible.ToBoolean method for the first column of the first row
		///     in the result set. If the value equal DBNull.Value, throw an exception.
		/// </returns>
		public static bool ExecuteBoolean(this DbCommand @this)
		{
			return Convert.ToBoolean(@this.ExecuteScalar());
		}

		#endregion Public Methods
	}
}