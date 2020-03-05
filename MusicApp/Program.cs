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
        public static List<AlbumClass> albumClasses = new List<AlbumClass>();

        // Lista de Albumes
        public static List<Album> albumes { get; set; } = new List<Album>();
        //Lista de Tracks
        public static List<Track> carrito;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            List<AlbumClass> lista = Functions.JsonParse<AlbumClass>(@"..\..\albums\albums.json");
            Album album;
            foreach (AlbumClass elem in lista)
            {

                //    //Obtenemos las imagenes del directorio
                //    System.Drawing.Image imagen = System.Drawing.Image.FromFile($@"..\..\albums\images\{elem.title}\{elem.title}.jpg");
                try
                {

                    album = new Album();
                    album.Name = elem.title;
                    album.Release_Date = elem.release_date;
                    List<Track> lista_t = Functions.JsonParse<Track>($@"..\..\albums\info\{elem.title}\.json");
                    album.Tracks = lista_t;

                    //Rellenamos la lista de albumes
                    albumes.Add(album);

                }
                catch { }
            }


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
