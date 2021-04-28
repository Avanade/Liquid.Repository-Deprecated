﻿using Liquid.Core.Exceptions;
using System;

namespace Liquid.Repository.Exceptions
{
    /// <summary>
    /// Occurs when a Repository database throw an error.
    /// </summary>
    public class DatabaseContextException : LightException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseContextException"/> class.
        /// </summary>
        /// <param name="message">Error message custom text.</param>
        /// <param name="innerException">Exception throwed by the client.</param>
        public DatabaseContextException(string message, Exception innerException) 
            : base(message, innerException)
        {
        }
    }
}