﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PointOfInterestType.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Runtime.Serialization;

namespace GW2DotNET.V1.Core.MapsInformation.Floors.Regions.Subregion.Locations
{
    /// <summary>
    /// Enumerates the known types of POI.
    /// </summary>
    public enum PointOfInterestType
    {
        /// <summary>The 'unknown' POI.</summary>
        [EnumMember(Value = "unknown")]
        Unknown = 0,

        /// <summary>The 'landmark' POI.</summary>
        [EnumMember(Value = "landmark")]
        Landmark = 1 << 0,

        /// <summary>The 'waypoint' POI.</summary>
        [EnumMember(Value = "waypoint")]
        Waypoint = 1 << 1,

        /// <summary>The 'vista' POI.</summary>
        [EnumMember(Value = "vista")]
        Vista = 1 << 2,

        /// <summary>The 'unlock' POI.</summary>
        [EnumMember(Value = "unlock")]
        Unlock = 1 << 3
    }
}