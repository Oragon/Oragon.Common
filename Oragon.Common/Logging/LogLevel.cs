using System.Runtime.Serialization;

namespace Oragon.Architecture.Logging
{
	[DataContract]
	public enum LogLevel
	{
		[EnumMember(Value = "Debug")]
		Debug = 1,

		[EnumMember(Value = "Trace")]
		Trace = 2,

		[EnumMember(Value = "Warn")]
		Warn = 3,

		[EnumMember(Value = "Error")]
		Error = 4,

		[EnumMember(Value = "Fatal")]
		Fatal = 5,

		[EnumMember(Value = "Audit")]
		Audit = 6
	}
}