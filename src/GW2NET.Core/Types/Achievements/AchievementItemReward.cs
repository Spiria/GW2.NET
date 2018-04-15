﻿// <copyright file="AchievementItemReward.cs" company="GW2.NET Coding Team">
// This product is licensed under the GNU General Public License version 2 (GPLv2). See the License in the project root folder or the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>

namespace GW2NET.Achievements
{
    using Items;

    public class AchievementItemReward : AchievementReward
    {
        public int ItemId { get; set; }

        public Item Item { get; set; }

        public int Count { get; set; }
    }
}