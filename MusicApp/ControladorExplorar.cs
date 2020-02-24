using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                System.Drawing.Image imagen = System.Drawing.Image.FromFile($@"..\..\albums\images\{elem.title}\{elem.title}.jpg");
                Object[] renglon = new Object[] { imagen, $"{elem.title}", "17-17-17" };
                Albums.Rows.Add(renglon);
            }
        }
    }
}
