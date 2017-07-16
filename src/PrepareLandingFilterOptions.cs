﻿using Steamworks;

namespace PrepareLanding
{
    public class PrepareLandingFilterOptions
    {
        /// <summary>
        ///     Allow "live filtering" or not (user doesn't have to click the filter button if active: filtering is done on the
        ///     fly).
        /// </summary>
        public bool AllowLiveFiltering {get; set;}

        public bool AllowImpassableHilliness { get; set; }

        public bool BypassMaxHighlightedTiles { get; set; }

        public bool ShowDebugTileId { get; set; }

        public bool DisablePreFilterCheck { get; set; }
    }
}