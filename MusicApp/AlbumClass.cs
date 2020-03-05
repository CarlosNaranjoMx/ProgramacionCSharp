using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace MusicApp
{
    
    public class AlbumClass
    {
        public string title { get; set; }
        //public Image cover_small { get; set; }
        //public List<string> genres { get; set; }
        public DateTime release_date { get; set; }

        //public Track[] Tracks { get; set; }

        public override string ToString()
        {
            return $"album name : {title}";
        }

    }
}
