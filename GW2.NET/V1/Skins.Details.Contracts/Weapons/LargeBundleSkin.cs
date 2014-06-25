﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LargeBundleSkin.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents a large bundle skin.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.V1.Skins.Details.Contracts.Weapons
{
    using GW2DotNET.Common;

    /// <summary>Represents a large bundle skin.</summary>
    [TypeDiscriminator(Value = "LargeBundle", BaseType = typeof(WeaponSkin))]
    public class LargeBundleSkin : WeaponSkin
    {
    }
}