using System.Collections.Generic;

namespace Oragon.Logging
{
	public interface ILogger
	{
		#region Public Methods

		void Audit(string context, string content, params object[] tags);

		void Debug(string context, string content, params object[] tags);

		void Error(string context, string content, params object[] tags);

		void Fatal(string context, string content, params object[] tags);

		void Log(string context, string content, LogLevel logLevel, IDictionary<string, object> tags);

		void Trace(string context, string content, params object[] tags);

		void Warn(string context, string content, params object[] tags);

		#endregion Public Methods
	}
}