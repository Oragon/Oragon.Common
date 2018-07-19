// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>0F8B7690-B992-4278-A104-DC05AF97191D</id>
		/// <summary>
		///     A DataTableCollection extension method that converts the @this to an IEnumerable.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>@this as an IEnumerable.</returns>
		public static IEnumerable<DataTable> AsEnumerable(this DataTableCollection @this)
		{
			return @this.Cast<DataTable>();
		}

		#endregion Public Methods
	}
}