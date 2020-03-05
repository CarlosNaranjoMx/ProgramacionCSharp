using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            ControladorExplorar.RellenaTabla(Albums);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Explorar explorar = new Explorar();
            explorar.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        //contenido de la tabla de Albumes, el boton de select
        private void Albums_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //no se activa en todos los casos
            //radioCancion.Checked = true;
            Canciones.DataSource = null;
            int indice_renglon;

            //obtenemos el valor del nombre del album
            String title ;

            int count;
            //leer los json de las canciones
            List<Track> lista;
            // el indice corresponde a la casilla del boton, SELECCIONAR CANCIONES
            if (e.ColumnIndex == 3)
            {

                //primero obtener estas
                indice_renglon = e.RowIndex;

                //obtenemos el valor del nombre del album
                 title = Albums.Rows[indice_renglon].Cells[1].Value.ToString();

                count = 0;
                //leer los json de las canciones
                lista = Functions.JsonParse<Track>($@"..\..\albums\info\{title}\.json");
                foreach (Track elem in lista)
                {
                    //agregar todas las canciones del album al carrito
                    //Program.carrito.Add(elem);
                    
                    var bc = new DataGridViewButtonColumn();
                    bc.HeaderText = "Carrito";
                    bc.Text = "Carrito";
                    Object[] obj_canciones = new Object[] { elem.Title,elem.Duration,elem.Artist.Name, bc };
                    //Agregamos al album de canciones
                    Canciones.Rows.Add(obj_canciones);
                }



                Albums.Visible = false;
                Canciones.Visible = true;

                //activar el radio boton
                radioCancion.Enabled = true;


            }

            if (e.ColumnIndex == 4)
            {

                //primero obtener estas
                indice_renglon = e.RowIndex;

                //obtenemos el valor del nombre del album
                title = Albums.Rows[indice_renglon].Cells[1].Value.ToString();

                count = 0;
                //leer los json de las canciones
                lista = Functions.JsonParse<Track>($@"..\..\albums\info\{title}\.json");
                foreach (Track elem in lista)
                {
                    //agregar todas las canciones del album al carrito
                    Program.carrito.Add(elem);

                    var bc = new DataGridViewButtonColumn();
                    bc.HeaderText = "Carrito";
                    bc.Text = "Carrito";
                    Object[] obj_canciones = new Object[] { elem.Title, elem.Duration, elem.Artist.Name, bc };
                    //Agregamos al album de canciones
                    Canciones.Rows.Add(obj_canciones);
                }



                //Albums.Visible = false;
                //Canciones.Visible = true;

                //activar el radio boton
                radioCancion.Enabled = true;


            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }


        private void Canciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



            if (e.ColumnIndex == 3)
            {
                //Recuperemos el Track
                Track track = new Track();
                Artist artist = new Artist();

                //obtenemos el valor del nombre del album
                track.Title = Canciones.Rows[e.RowIndex].Cells[0].Value.ToString();
                track.Duration = (int) Canciones.Rows[e.RowIndex].Cells[1].Value;
                //track.Track_Position = 0;
                artist.Name = Canciones.Rows[e.RowIndex].Cells[2].Value.ToString();
                track.Artist = artist;
                track.Price = 30;
                Program.carrito.Add(track);
            }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        { 
            Carrito carrito = new Carrito();
            carrito.ShowDialog();
        }

        //raio de album
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Canciones.DataSource= null;
            if (radioButton2.Checked)
            {
                if (Canciones.Visible) Canciones.Visible = false; 
                if(!Albums.Visible) Albums.Visible = true;
            }
        }

        //El de canciones
        private void radioCancion_CheckedChanged(object sender, EventArgs e)
        {
            Canciones.DataSource = null;
            if (radioCancion.Checked)
            {
                foreach (Album album in Program.albumes )
                {
                    foreach(Track track in album.Tracks)
                    {

                        var bc = new DataGridViewButtonColumn();
                        bc.HeaderText = "Carrito";
                        bc.Text = "Carrito";
                        Object[] obj_canciones = new Object[] { track.Title, track.Duration, track.Artist.Name, bc };
                        //Agregamos al album de canciones
                        Canciones.Rows.Add(obj_canciones);
                    }
                }
            }
        }


    }
}
