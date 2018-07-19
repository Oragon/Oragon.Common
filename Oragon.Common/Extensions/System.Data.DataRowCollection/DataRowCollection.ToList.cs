// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>941128A8-415E-4EDF-ABDA-3734D41D3CC7</id>
		/// <summary>
		///     A DataRowCollection extension method that converts the @this to a list.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>@this as a List&lt;DataRow&gt;</returns>
		public static List<DataRow> ToList(this DataRowCollection @this)
		{
			return @this.Cast<DataRow>().ToList();
		}

		#endregion Public Methods
	}
}