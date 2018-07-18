using System;
using System.Linq;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		public static T GetCustomAttribute<T>(this System.Reflection.Assembly @this)
			where T : Attribute
		{
			T attr = (T)@this.GetCustomAttributes(typeof(T), true).FirstOrDefault();
			return attr;
		}

		#endregion Public Methods
	}
}