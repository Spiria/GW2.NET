﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApiManager.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   This is the one and only class that is directly instantiated
//   by the caller. All functionality is accessed through the
//   properties of this object.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using GW2DotNET.V1.Guilds.DataProvider;
using GW2DotNET.V1.Infrastructure;
using GW2DotNET.V1.Items.DataProvider;
using GW2DotNET.V1.Maps.DataProvider;
using GW2DotNET.V1.World.DataProvider;

namespace GW2DotNET.V1
{
    using System.Collections.Generic;
    using System.Linq;

    using GW2DotNET.V1.Infrastructure.Logging;

    /// <summary>
    /// This is the one and only class that is directly instantiated
    /// by the caller. All functionality is accessed through the
    /// properties of this object.
    /// </summary>
    public class ApiManager
    {
        /// <summary>Backing field for the event logger.</summary>
        private readonly EventLogger logger;

        /// <summary>The build.</summary>
        private int build = -1;

        /// <summary>Backing field for the continent data.</summary>
        private ContinentData continentData;

        /// <summary>Backing field for the map data.</summary>
        private MapsData mapData;

        /// <summary>
        /// Backing field for Colours property
        /// </summary>
        private ColourData colourData;

        /// <summary>
        /// Backing field for Events property
        /// </summary>
        private EventData eventData;

        /// <summary>The floor data.</summary>
        private MapFloorData floorData;

        /// <summary>
        /// Backing field for Guilds property
        /// </summary>
        private GuildData guildData;

        /// <summary>
        /// Backing field for Items property
        /// </summary>
        private ItemData itemData;

        /// <summary>
        /// Backing field for wvwMatches property
        /// </summary>
        private WvW.DataProvider matchData;

        /// <summary>
        /// Backing field for Recipes property
        /// </summary>
        private RecipeData recipeData;

        /// <summary>
        /// Backing field for Worlds property
        /// </summary>
        private WorldData worldData;

        /// <summary>
        /// Stores the language set by the constructor
        /// </summary>
        private Language language;

        /// <summary>Initializes a new instance of the <see cref="ApiManager"/> class.</summary>
        public ApiManager()
        {
            this.language = Language.En;
            this.logger = new EventLogger();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiManager"/> class.
        /// </summary>
        /// <param name="language">
        /// The language for things such as world names.
        /// </param>
        public ApiManager(Language language)
        {
            this.language = language;
            this.logger = new EventLogger();
        }

        /// <summary>Gets the build.</summary>
        public int Build
        {
            get
            {
                if (this.build <= 0)
                {
                    this.GetLatestBuild();
                }

                return this.build;
            }
        }

        /// <summary>Gets or sets the language.</summary>
        /// <remarks>This property sets the language.
        /// This will also clear the complete cache
        /// so the user will get the data from the api in the set language.</remarks>
        public Language Language
        {
            get
            {
                return this.language;
            }

            set
            {
                this.ClearCache();

                this.language = value;
            }
        }

        /// <summary>Gets the logger.</summary>
        public EventLogger Logger
        {
            get
            {
                return this.logger;
            }
        }

        /// <summary>Gets the continent data.</summary>
        public ContinentData Continents
        {
            get
            {
                return this.continentData ?? (this.continentData = new ContinentData(this));
            }
        }

        /// <summary>Gets the floor data.</summary>
        public MapFloorData FloorData
        {
            get
            {
                return this.floorData ?? (this.floorData = new MapFloorData(this));
            }
        }

        /// <summary>Gets the maps data.</summary>
        public MapsData Maps
        {
            get
            {
                return this.mapData ?? (this.mapData = new MapsData(this));
            }
        }

        /// <summary>
        /// Gets the ColourData object.
        /// </summary>
        public ColourData Colours
        {
            get
            {
                return this.colourData ?? (this.colourData = new ColourData(this));
            }
        }

        /// <summary>
        /// Gets the EventData object.
        /// </summary>
        public EventData Events
        {
            get
            {
                return this.eventData ?? (this.eventData = new EventData(this));
            }
        }

        /// <summary>
        /// Gets the GuildData object.
        /// </summary>
        public GuildData Guilds
        {
            get
            {
                return this.guildData ?? (this.guildData = new GuildData(this));
            }
        }

        /// <summary>
        /// Gets the ItemData object.
        /// </summary>
        public ItemData Items
        {
            get
            {
                return this.itemData ?? (this.itemData = new ItemData(this));
            }
        }

        /// <summary>
        /// Gets the RecipeData object.
        /// </summary>
        public RecipeData Recipes
        {
            get
            {
                return this.recipeData ?? (this.recipeData = new RecipeData());
            }
        }

        /// <summary>
        /// Gets the MatchData object.
        /// </summary>
        public WvW.DataProvider WvWMatches
        {
            get
            {
                return this.matchData ?? (this.matchData = new WvW.DataProvider());
            }
        }

        /// <summary>
        /// Gets the WorldData object.
        /// </summary>
        public WorldData Worlds
        {
            get
            {
                return this.worldData ?? (this.worldData = new WorldData(this));
            }
        }

        /// <summary>Clears the cache.
        /// WARNING! there is  no undo!</summary>
        public void ClearCache()
        {
            // Old way to clear the cache.
            this.colourData = null;
            this.eventData = null;
            this.guildData = null;
            this.itemData = null;
            this.continentData = null;
            this.floorData = null;
            this.matchData = null;
            this.recipeData = null;
            this.worldData = null;

            // New way
            this.WvWMatches.ClearCache();
        }

        /// <summary>Gets the latest build from the server.</summary>
        /// <returns>The latest build.</returns>
        public int GetLatestBuild()
        {
            this.build = ApiCall.GetContent<Dictionary<string, int>>("build.json", null, ApiCall.Categories.Miscellaneous).Values.Single();

            return this.build;
        }
    }
}