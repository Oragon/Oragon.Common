// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Collections.Generic;
using System.Linq;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		public static Stack<T> ToStack<T>(this IEnumerable<T> @this)
		{
			Stack<T> returnValue = new Stack<T>(@this);
			return returnValue;
		}

		public static Stack<T> ToStackAscending<T, TKey>(this IEnumerable<T> @this, Func<T, TKey> keySelector)
		{
			return @this.OrderBy(keySelector).ToStack();
		}

		public static Stack<T> ToStackDescending<T, TKey>(this IEnumerable<T> @this, Func<T, TKey> keySelector)
		{
			return @this.OrderBy(keySelector).ToStack();
		}

		#endregion Public Methods
	}
}