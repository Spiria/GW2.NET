﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EventDetailsResponse.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using GW2DotNET.V1.Core.Converters;
using Newtonsoft.Json;

namespace GW2DotNET.V1.Core.EventDetails
{
    /// <summary>
    /// Represents a response that is the result of an <see cref="EventDetailsRequest"/>.
    /// </summary>
    /// <remarks>
    /// See <a href="http://wiki.guildwars2.com/wiki/API:1/event_details"/> for more information.
    /// </remarks>
    public class EventDetailsResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventDetailsResponse"/> class.
        /// </summary>
        public EventDetailsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventDetailsResponse"/> class.
        /// </summary>
        /// <param name="eventDetails">The list of event details.</param>
        public EventDetailsResponse(Dictionary<Guid, DynamicEventDetails> eventDetails)
        {
            this.EventDetails = eventDetails;
        }

        /// <summary>
        /// Gets or sets a list of details about dynamic events.
        /// </summary>
        [JsonProperty("events")]
        [JsonConverter(typeof(GuidDictionaryConverter<DynamicEventDetails>))]
        public Dictionary<Guid, DynamicEventDetails> EventDetails { get; set; }

        /// <summary>
        /// Gets the JSON representation of this instance.
        /// </summary>
        /// <returns>Returns a JSON <see cref="String"/>.</returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}