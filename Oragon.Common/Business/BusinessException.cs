using System;
using System.Collections.Generic;
using System.Text;

namespace Oragon.Business
{
    /// <summary>
	///     Classe base para exceções de negócio.
	/// </summary>
	[Serializable]
    public class BusinessException : Exception
    {
        #region Public Constructors

        public BusinessException()
        {
        }

        public BusinessException(string message)
            : base(message)
        {
        }

        public BusinessException(string message, Exception inner)
            : base(message, inner)
        {
        }

        #endregion Public Constructors

        #region Protected Constructors

        protected BusinessException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }

        #endregion Protected Constructors
    }
}
