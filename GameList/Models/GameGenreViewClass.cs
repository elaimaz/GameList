﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;


namespace GameList.Models
{
    public class GameGenreViewClass
    {
        public List<Game> Games { get; set; }
        public SelectList Genres { get; set; }
        public string GameGenre { get; set; }
        public string SearchString { get; set; }
    }
}
