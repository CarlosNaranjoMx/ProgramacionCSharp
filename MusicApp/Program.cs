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
        // Lista de ALbumsClass
        public static List<AlbumClass> albumClasses;

        // Lista de Albumes
        public static List<Album> albumes;
        // Lista de Canciones
        public static List<Canciones> canciones;
        //Lista de Tracks
        public static List<Track> carrito;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            // Transformamos todas las canciones en objetos
            string jsonString = File.ReadAllText("tracks.json");
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };
            albumes = JsonSerializer.Deserialize<List<Album>>(jsonString, options);
            carrito = (from album in albumes
                       from track in album.Tracks
                       select track).ToList();


            //carrito = new List<Track>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Inicio());
        }
    }
}
