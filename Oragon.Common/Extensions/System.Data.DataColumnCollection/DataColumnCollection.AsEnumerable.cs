// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>E3F7A75F-F5A9-47C2-BC2C-BF2562BBAC9D</id>
		/// <summary>
		///     A DataColumnCollection extension method that enumerables the given object.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>The IEnumerable object.</returns>
		public static IEnumerable<DataColumn> AsEnumerable(this DataColumnCollection @this)
		{
			return @this.Cast<DataColumn>();
		}

		#endregion Public Methods
	}
}