// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Net.Mail;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>91D48A5D-6309-40C8-80C0-C838817C013A</id>
		/// <summary>
		///     A MailMessage extension method that sends this message asynchronous.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <param name="userToken">The user token.</param>
		public static void SendAsync(this MailMessage @this, object userToken)
		{
			using (var smtpClient = new SmtpClient())
			{
				smtpClient.SendAsync(@this, userToken);
			}
		}

		#endregion Public Methods
	}
}