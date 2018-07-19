// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using Oragon.ExtendedTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
		public static IEnumerable<Range<T>> Reduce<T>(this IEnumerable<Range<T>> @this)
			 where T : struct, IComparable<T>, IEquatable<T>
		{
			if (@this == null || @this.Count() <= 1)
				return @this;

			Queue<Range<T>> processQueue = new Queue<Range<T>>(@this.OrderBy(it => it.Start));
			Stack<Range<T>> outputStack = new Stack<Range<T>>();

			Range<T> last = null;
			while (processQueue.Count > 0)
			{
				Range<T> next = processQueue.Dequeue();
				if (last != null)
				{
					T? startValue = null;
					if (last.Start.HasValue && next.Start.HasValue)
					{
						startValue = (new T[] { last.Start.Value, next.Start.Value }).Min();
					}
					T? endValue = null;
					if (last.End.HasValue && next.End.HasValue)
					{
						endValue = (new T[] { last.End.Value, next.End.Value }).Min();
					}
					outputStack.Push(new Range<T>(startValue, endValue));
				}
				else
					outputStack.Push(next);

				last = next;
			}
			return outputStack.Reverse();
		}

		#endregion Public Methods
	}
}