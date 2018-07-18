// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Linq;
using System.Linq.Expressions;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <summary>
		///     Concatena duas express�es lambda que retornam bool.
		/// </summary>
		/// <returns>Retorna uma express�o lambda com o retorno sendo o AND l�gico das duas express�es.</returns>
		public static Expression<Func<T, bool>> And<T>(this Expression<Func<T, bool>> expr1, Expression<Func<T, bool>> expr2)
		{
			var invokedExpr = Expression.Invoke(expr2, expr1.Parameters.Cast<Expression>());
			return Expression.Lambda<Func<T, bool>>
				(Expression.AndAlso(expr1.Body, invokedExpr), expr1.Parameters);
		}

		#endregion Public Methods
	}
}