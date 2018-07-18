// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Collections.Generic;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		public static IDictionary<string, object> ToDictionary(this string[] stringArray)
		{
			Dictionary<string, object> returnDic = new Dictionary<string, object>();
			if (stringArray.Length > 0)
			{
				if (stringArray.Length % 2 != 0)
					throw new InvalidOperationException("Number of Tags must be divisible by two");
				else
				{
					int keyIndex = 0;
					int valueIndex = 1;
					for (; valueIndex < stringArray.Length; keyIndex += 2, valueIndex += 2)
					{
						returnDic.Add(stringArray[keyIndex], stringArray[valueIndex]);
					}
				}
			}
			return returnDic;
		}

		#endregion Public Methods
	}
}