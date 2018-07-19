// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Collections.Generic;
using System.Linq;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		public static Queue<T> ToQueue<T>(this IEnumerable<T> @this)
		{
			Queue<T> returnValue = new Queue<T>(@this);
			return returnValue;
		}

		public static Queue<T> ToQueueAscending<T, TKey>(this IEnumerable<T> @this, Func<T, TKey> keySelector)
		{
			return @this.OrderBy(keySelector).ToQueue();
		}

		public static Queue<T> ToQueueDescending<T, TKey>(this IEnumerable<T> @this, Func<T, TKey> keySelector)
		{
			return @this.OrderBy(keySelector).ToQueue();
		}

		#endregion Public Methods
	}
}