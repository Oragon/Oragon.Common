using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Oragon.Architecture.Logging
{
	/// <summary>
	///     Classe LogEntry.
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public partial class LogEntry
	{
		#region Public Properties

		/// <summary>
		///     Define ou obtém um(a) Content da LogEntry.
		/// </summary>
		[DataMember]
		public virtual string Content { get; set; }

		/// <summary>
		///     Define ou obtém um(a) Context da LogEntry.
		/// </summary>
		[DataMember]
		public virtual string Context { get; set; }

		/// <summary>
		///     Define ou obtém um(a) Date da LogEntry.
		/// </summary>
		[DataMember]
		public virtual DateTime Date { get; set; }

		/// <summary>
		///     Define ou obtém um(a) LogLevel da LogEntry.
		/// </summary>
		[DataMember]
		[JsonProperty("LogLevel")]
		[JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
		public virtual LogLevel LogLevel { get; set; }

		/// <summary>
		///     Define ou obtém um(a) LogLevel da LogEntry.
		/// </summary>
		[DataMember]
		public virtual IDictionary<string, object> Tags { get; set; }

		[DataMember]
		public virtual string ProjectKey { get; set; }

		#endregion Public Properties

		//public LogEntryTransferObject()
		//{ }

		//public LogEntryTransferObject(LogEntry logEntry)
		//{
		//	this.LogEntryID = logEntry.LogEntryID;
		//	this.Date = logEntry.Date;
		//	this.Content = logEntry.Content;
		//	this.LogLevelID = logEntry.Level.LevelID;
		//	this.LogLevelName = logEntry.Level.Name;
		//	this.Tags = new Dictionary<string, string>();
		//	foreach(TagValue tagValue in logEntry.TagValues)
		//	{
		//		this.Tags.Add(tagValue.Tag.Name, tagValue.Value);
		//	}
		//}
	}
	
}