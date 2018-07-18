// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>9BCDD187-0372-4B95-819A-8B911FFEF8BC</id>
		/// <summary>
		///     An object extension method that converts the @this to a boolean.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>@this as a bool.</returns>
		public static IDictionary<string, object> ToDictionary(this object @this)
		{
			Dictionary<string, object> returnValue = new Dictionary<string, object>();

			if (@this is IDictionary<string, object>)
				return (IDictionary<string, object>)@this;

			if (@this is IEnumerable)
			{
				object[] dataItems = ((IEnumerable)@this).Cast<object>().ToArray();
				int count = dataItems.Length;
				if (count % 2 != 0)
					throw new InvalidOperationException("Number of Tags must be divisible by two");
				else
				{
					int keyIndex = 0;
					int valueIndex = 1;
					for (; valueIndex < count; keyIndex += 2, valueIndex += 2)
					{
						returnValue.Add((string)dataItems[keyIndex], dataItems[valueIndex]);
					}
				}
			} else
			{
				var attr = System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance;
				foreach (var property in @this.GetType().GetProperties(attr))
				{
					if (property.CanRead)
					{
						returnValue.Add(property.Name, property.GetValue(@this, null));
					}
				}
			}
			return returnValue;
		}

		#endregion Public Methods
	}
}