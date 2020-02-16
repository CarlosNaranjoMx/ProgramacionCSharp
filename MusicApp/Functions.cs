using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json; 

namespace MusicApp
{
    public static class Functions
    {
        public static List<A> JsonParse<A>(string path)
        {
            string json = System.IO.File.ReadAllText(path);
            List<A> items = JsonConvert.DeserializeObject<List<A>>(json);
            return items;
        }
    }
}
