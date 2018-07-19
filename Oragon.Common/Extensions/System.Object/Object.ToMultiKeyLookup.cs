// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using FluentAssertions;
using System.Linq;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		///<summary>
		///Creates a <see cref="Lookup{TKey,TElement}"/> from an <see cref="IEnumerable{T}"/> according to a specified key selector function. <b>The funtion can return zero, one or several keys for an element.</b>.
		///</summary>
		///<remarks>
		///The difference with <seealso cref="Enumerable.ToLookup{TSource,TKey}(System.Collections.Generic.IEnumerable{TSource},System.Func{TSource,TKey})"/> is that an element can have zero, one or several keys.<br/>
		///Hence an element can be contained in several groups, if it has several keys.
		///</remarks>
		///<typeparam name="T">The type of the elements of <paramref name="seq"/>.</typeparam>
		///<typeparam name="TKey">The type of the keys in the result <see cref="Lookup{TKey,TElement}"/>.</typeparam>
		///<param name="seq">An <i>IEnumerable&lt;T&gt;</i> to create an hashset from.</param>
		///<param name="func">A function to extract a sequence of keys from each element.</param>
		///<returns>An hashset that contains the elements from the input sequence.</returns>
		///<seealso cref="Enumerable.ToLookup{TSource,TKey}(System.Collections.Generic.IEnumerable{TSource},System.Func{TSource,TKey})"/>
		public static ILookup<TKey, T> ToMultiKeyLookup<T, TKey>(this IEnumerable<T> seq, Func<T, IEnumerable<TKey>> func)
		{
			seq.Should().NotBeNull("seq must not be null");
			func.Should().NotBeNull("func must not be null");
			Debug.Assert(seq != null);
			var dicoLookup = new DicoLookup<TKey, T>();
			foreach (var elem in seq)
			{
				var keys = func(elem);
				if (keys == null) { continue; }
				foreach (var key in keys)
				{
					IEnumerable<T> seqTmp;
					if (!dicoLookup.TryGetValue(key, out seqTmp))
					{
						// A single sequence is added first, and if several elements share the same key we transform the single sequence into a list.
						// This is an optimisation because a single sequence is cheaper than a List<T>, and we hope that most keys are not not shared
						// by several elements.
						dicoLookup.Add(key, elem.ToEnumerable());
						continue;
					}
					var list = seqTmp as List<T>;
					if (list != null)
					{
						list.Add(elem);
						continue;
					}
					list = new List<T> { seqTmp.First(), elem };
					dicoLookup[key] = list;
				}
			}
			return dicoLookup;
		}

		#endregion Public Methods
	}
}