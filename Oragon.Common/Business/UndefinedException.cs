using System;

namespace Oragon.Business
{
    /// <summary>
	///     Define uma exception não gerenciada tratada pelo mecanismo de exception replacement
	/// </summary>
	[Serializable]
    public class UndefinedException : BusinessException
    {
        #region Public Constructors

        public UndefinedException()
        {
        }

        public UndefinedException(string message)
            : base(message)
        {
        }

        public UndefinedException(string message, Exception inner)
            : base(message, inner)
        {
        }

        #endregion Public Constructors

        #region Protected Constructors

        protected UndefinedException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }

        #endregion Protected Constructors
    }
}
