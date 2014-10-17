﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceException.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents an API error.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2NET.Common
{
    using System;

    /// <summary>Represents an API error.</summary>
    /// <remarks>See <a href="http://wiki.guildwars2.com/wiki/API:1" /> for more information regarding API errors.</remarks>
    public sealed class ServiceException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceException"/> class.
        /// </summary>
        public ServiceException()
        {
        }

        /// <summary>Initializes a new instance of the <see cref="ServiceException"/> class with a specified error message.</summary>
        /// <param name="message">The message that describes the error. </param>
        public ServiceException(string message)
            : base(message)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="ServiceException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
        /// <param name="message">The error message that explains the reason for the exception. </param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified. </param>
        public ServiceException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}