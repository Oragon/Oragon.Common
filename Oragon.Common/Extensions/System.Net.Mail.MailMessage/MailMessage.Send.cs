// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Net.Mail;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>AF13329F-7CB1-4448-8D6B-9FD6E0E22971</id>
		/// <summary>
		///     A MailMessage extension method that send this message.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		public static void Send(this MailMessage @this)
		{
			using (var smtpClient = new SmtpClient())
			{
				smtpClient.Send(@this);
			}
		}

		#endregion Public Methods
	}
}