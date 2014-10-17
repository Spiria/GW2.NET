﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExchangeQuote.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents the gems from/to gold exchange rate.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2NET.Entities.Commerce
{
    using System;

    /// <summary>Represents the gems from/to gold exchange rate.</summary>
    public class ExchangeQuote
    {
        /// <summary>Gets or sets the coins per gem.</summary>
        public int CoinsPerGem { get; set; }

        /// <summary>Gets or sets the identifier.</summary>
        public string Id { get; set; }

        /// <summary>Gets or sets the number of gems/coins to receive.</summary>
        public long Receive { get; set; }

        /// <summary>Gets or sets the number of gems/coins to send.</summary>
        public long Send { get; set; }

        /// <summary>Gets or sets the timestamp.</summary>
        public DateTimeOffset Timestamp { get; set; }
    }
}