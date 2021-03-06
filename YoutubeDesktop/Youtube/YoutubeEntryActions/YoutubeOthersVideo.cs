﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YoutubeDesktop.Youtube.YoutubeEntryActions
{
    // Object should also throw Navigation intents, 
    // that should be handled by the navigation pane

    // Methods that return object and have no parameters / one parameter of type YoutubePlaylist
    // Will be harvested and used to fill ContextMenus
    // Extra parameters will be filled by hand

    public abstract class YoutubeOthersVideo : YoutubeVideo
    {

        public YoutubeOthersVideo(string videoId, YoutubeEntry raw) : base(videoId, raw) { }
        
        // youtube other-user's videos actions


    }
}
