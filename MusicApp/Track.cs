using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    class Track
    {
        public string Title { get; set; }
        public int Duration { get; set; }
        public int Track_Position { get; set; }
        public Artist Artist { get; set; }
        public float Price { get; set; }
    }
}
