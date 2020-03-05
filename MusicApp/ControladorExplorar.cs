using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public static class ControladorExplorar
    {
        public static void RellenaTabla(System.Windows.Forms.DataGridView Albums)
        {
            List<AlbumClass> lista = Functions.JsonParse<AlbumClass>(@"..\..\albums\albums.json");
            foreach (AlbumClass elem in lista)
            {
                //Mostrar Nombres de los albums
                //using (StreamWriter sw = File.AppendText(@"..\..\WriteText.txt"))
                //{
                //    sw.WriteLine(elem.ToString());
                //}
                // tHe given path format is not supported
                try
                {

                    //Rellenamos la lista de albumes
                    

                    //Obtenemos las imagenes del directorio
                    System.Drawing.Image imagen = System.Drawing.Image.FromFile($@"..\..\albums\images\{elem.title}\{elem.title}.jpg");

                    //Creamos el boton de la tabla
                    var bc = new DataGridViewButtonColumn();
                    bc.HeaderText = "Carrito";
                    bc.Text = "Carrito";
                    bc.UseColumnTextForButtonValue = true;

                    Object[] renglon = new Object[] { imagen, $"{elem.title}", $"{elem.release_date}", bc };
                    
                    // Modificamos el alto de los renglones
                    Albums.RowTemplate.Height = 50;


                    Albums.Rows.Add(renglon);

                }
                catch { 
                
                }
            }
        }
    }
}
