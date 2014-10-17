﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ImmediateConsumable.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents an immediate consumable item.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2NET.Entities.Items
{
    using System;

    /// <summary>Represents an immediate consumable item.</summary>
    public class ImmediateConsumable : Consumable
    {
        /// <summary>Gets or sets the consumable's effect duration.</summary>
        public virtual TimeSpan? Duration { get; set; }

        /// <summary>Gets or sets the consumable's effect.</summary>
        public virtual string Effect { get; set; }
    }
}