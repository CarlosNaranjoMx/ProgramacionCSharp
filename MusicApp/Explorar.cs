using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class Explorar : Form
    {
        public Explorar()
        {
            InitializeComponent();
            RellenaTabla();
        }

        public void RellenaTabla()
        {
            List<AlbumClass> lista = Functions.JsonParse<AlbumClass>(@"..\..\albums\albums.json");
            foreach (AlbumClass elem in lista)
            {   
                //Mostrar Nombres de los alubums
                //using (StreamWriter sw = File.AppendText(@"..\..\WriteText.txt"))
                //{
                //    sw.WriteLine(elem.ToString());
                //}
                Image imagen = Image.FromFile($@"..\..\albums\images\{elem.title}\{elem.title}.jpg");
                Object[] renglon = new Object[] {imagen,$"{elem.title}","17-17-17"};
                Albums.Rows.Add(renglon);
            }
        }   

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
