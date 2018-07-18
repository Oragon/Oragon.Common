// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using FluentAssertions;
using Oragon.Architecture.ExtendedTypes;
using System;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1")]
		public static bool IsIn<T>(this T value, Range<T> interval)
			 where T : struct, IComparable<T>, IEquatable<T>
		{
			interval.Should().NotBeNull();
			interval.Start.Should().NotBeNull();
			value.Should().NotBeNull();

			bool returnValue = true;
			if (interval.Start.HasValue)
				returnValue &= (value.CompareTo(interval.Start.Value) >= 0);

			if (interval.End.HasValue)
				returnValue &= (value.CompareTo(interval.End.Value) <= 0);

			return returnValue;
		}

		#endregion Public Methods
	}
}