﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    class Album
    {
        public string Name { get; set; }
        public List<Track> Tracks { get; set; }
        public int Total { get; set; }
        public string Genre { get; set; }
        public DateTime Release_Date { get; set; }
        public int Duration { get; set; }
    }
}
