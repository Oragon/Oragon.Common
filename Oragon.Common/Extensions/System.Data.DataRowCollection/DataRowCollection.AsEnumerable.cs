// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>BC14CECD-26C7-4F9D-866B-1B990A55DE4E</id>
		/// <summary>
		///     A DataRowCollection extension method that converts the @this to an IEnumerable.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>@this as an IEnumerable.</returns>
		public static IEnumerable<DataRow> AsEnumerable(this DataRowCollection @this)
		{
			return @this.Cast<DataRow>();
		}

		#endregion Public Methods
	}
}