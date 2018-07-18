// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.IO;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>00195CBF-C786-4433-AA59-6DA43DC97BFA</id>
		/// <summary>
		///     A string extension method that save the string into a file.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <param name="fileName">Filename of the file.</param>
		/// <param name="append">(Optional) if we should append to the file.</param>
		public static void SaveAs(this string @this, string fileName, bool append = false)
		{
			using (TextWriter tw = new StreamWriter(fileName, append))
			{
				tw.Write(@this);
			}
		}

		/// <id>705EA2EC-C899-4D6D-9456-C4B30DCFC311</id>
		/// <summary>
		///     A string extension method that save the string into a file.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <param name="file">The FileInfo.</param>
		/// <param name="append">(Optional) if we should append to the file.</param>
		public static void SaveAs(this string @this, FileInfo file, bool append = false)
		{
			using (TextWriter tw = new StreamWriter(file.FullName, append))
			{
				tw.Write(@this);
			}
		}

		#endregion Public Methods
	}
}