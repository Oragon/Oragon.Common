// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>AA7134EC-AD33-4669-AC55-5EA7EF765373</id>
		/// <summary>
		///     A DataTableCollection extension method that converts the @this to a list.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>@this as a List&lt;DataTable&gt;</returns>
		public static List<DataTable> ToList(this DataTableCollection @this)
		{
			return @this.Cast<DataTable>().Select(x => x).ToList();
		}

		#endregion Public Methods
	}
}