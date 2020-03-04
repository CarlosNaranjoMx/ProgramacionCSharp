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
        static List<Album> albumes;
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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Inicio());
        }
    }
}
