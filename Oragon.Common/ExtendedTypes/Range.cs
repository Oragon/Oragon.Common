using System;
using System.Diagnostics;
using FluentAssertions;

namespace Oragon.ExtendedTypes
{
	public class Range<T> : IEquatable<Range<T>>
		 where T : struct, IComparable<T>, IEquatable<T>
	{
		#region Protected Fields

		protected Nullable<T> StartValue { get; set; }
		protected Nullable<T> EndValue { get; set; }

		#endregion Protected Fields

		#region Public Constructors

		public Range()
			: this(new Nullable<T>(), new Nullable<T>())
		{
		}

		[DebuggerStepThrough]
		public Range(Nullable<T> start, Nullable<T> end)
		{
			AssertstartFollowsend(start, end);
			this.StartValue = start;
			this.EndValue = end;
		}

		#endregion Public Constructors

		#region Public Properties

		public Nullable<T> End
		{
			get { return EndValue; }
			set
			{
				AssertstartFollowsend(this.StartValue, value);
				EndValue = value;
			}
		}

		public Nullable<T> Start
		{
			get { return StartValue; }
			set
			{
				AssertstartFollowsend(value, this.EndValue);
				StartValue = value;
			}
		}

		#endregion Public Properties

		#region Public Methods

		public bool Equals(Range<T> other)
		{
			if (object.ReferenceEquals(other, null)) return false;

			return
				(Nullable.Compare<T>(this.StartValue, other.StartValue) == 0)
				&&
				(Nullable.Compare<T>(this.EndValue, other.EndValue) == 0);
		}

		[DebuggerStepThrough]
		public Range<T> GetIntersection(Range<T> other)
		{
			if (!Intersects(other)) throw new InvalidOperationException("Ranges do not intersect");
			return new Range<T>(GetLaterstart(other.Start), GetEarlierend(other.End));
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0")]
		public bool Intersects(T other)
		{
			other.Should().NotBeNull();
			bool returnValue = (
				(
					this.StartValue.HasValue == false
					||
					(
						this.StartValue.HasValue
						&&
						this.StartValue.Value.CompareTo(other) <= 0
					)
				)
				&&
				(
					this.EndValue.HasValue == false
					||
					(
						this.EndValue.HasValue
						&&
						this.EndValue.Value.CompareTo(other) >= 0
					)
				)
			);

			return returnValue;
		}


		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0")]
		public bool Intersects(Range<T> other)
		{
			other.Should().NotBeNull();
			if (
				(
					this.StartValue.HasValue
					&&
					other.End.HasValue
					&&
					other.End.Value.CompareTo(this.StartValue.Value) <= 0
				)
				||
				(
					this.EndValue.HasValue
					&&
					other.Start.HasValue
					&&
					other.Start.Value.CompareTo(this.EndValue.Value) >= 0
				)
				||
				(
					other.Start.HasValue
					&&
					this.EndValue.HasValue
					&&
					this.EndValue.Value.CompareTo(other.Start.Value) <= 0
				)
				||
				(
					other.End.HasValue
					&&
					this.StartValue.HasValue
					&&
					this.StartValue.Value.CompareTo(other.End.Value) >= 0
				)
			)
			{
				return false;
			}
			return true;
		}

		#endregion Public Methods

		#region Private Methods

		[DebuggerStepThrough]
		private static void AssertstartFollowsend(Nullable<T> start, Nullable<T> end)
		{
			if (
				(start.HasValue && end.HasValue) && (end.Value.CompareTo(start.Value) < 0))
				throw new InvalidOperationException("Start must be less than or equal to End");
		}

		private Nullable<T> GetEarlierend(Nullable<T> other)
		{
			//!end.HasValue == +infinity, not negative infinity
			//as is the case with !start.HasValue
			if (Nullable.Compare<T>(EndValue, other) == 0) return other;
			if (EndValue.HasValue && !other.HasValue) return EndValue;
			if (!EndValue.HasValue && other.HasValue) return other;
			return (Nullable.Compare<T>(EndValue, other) >= 0) ? other : EndValue;
		}

		private Nullable<T> GetLaterstart(Nullable<T> other)
		{
			return Nullable.Compare<T>(StartValue, other) >= 0 ? StartValue : other;
		}

		#endregion Private Methods
	}
}