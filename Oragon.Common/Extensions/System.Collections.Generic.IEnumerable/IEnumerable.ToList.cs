// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Collections.Generic;
using System.Linq;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		public static List<TResult> ToList<TSource, TResult>(this IEnumerable<TSource> @this, Func<TSource, TResult> selector)
		{
			return @this.Select<TSource, TResult>(selector).ToList();
		}

		#endregion Public Methods
	}
}