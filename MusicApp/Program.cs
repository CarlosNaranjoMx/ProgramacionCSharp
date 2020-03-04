using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.Json;

namespace MusicApp
{
    static class Program
    {
        public static List<Album> albumes;
        public static List<Track> carrito;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string jsonString = File.ReadAllText("tracks.json");
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };

            albumes = JsonSerializer.Deserialize<List<Album>>(jsonString, options);
            /*carrito = (from album in albumes
                       from track in album.Tracks
                       select track).ToList();*/
            carrito = new List<Track>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Inicio());
        }
    }
}
