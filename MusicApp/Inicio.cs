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

        //contenido de la tabla de Albumes
        private void Albums_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // el indice corresponde a la casilla del boton
            if (e.ColumnIndex == 3)
            {

                //primero obtener estas
                int indice_renglon = e.RowIndex;

                //obtenemos el valor del nombre del album
                 String title = Albums.Rows[indice_renglon].Cells[1].Value.ToString();


                //leer los json de las canciones
                List<Cancion> lista = Functions.JsonParse<Cancion>($@"..\..\albums\info\{title}\.json");
                foreach (Cancion elem in lista)
                {
                    var bc = new DataGridViewButtonColumn();
                    bc.HeaderText = "Carrito";
                    bc.Text = "Carrito";
                    Object[] obj_canciones = new Object[] { elem.title, "", bc };
                    //Agregamos al album de canciones
                    Canciones.Rows.Add(obj_canciones);
                }



                Albums.Visible = false;
                Canciones.Visible = true;

                //activar el radio boton
                radioCancion.Enabled = true;

                //Carrito carrito = new Carrito();
                //carrito.ShowDialog();


                //radioArtista.Select;

                //trackBindingSource.RemoveAt(e.RowIndex);
                //if (trackBindingSource.Count > 0)
                //{
                //    var totalPrice = Program.carrito.Select(t => t.Price).Aggregate((p1, p2) => p1 + p2);
                //    totalPriceText.Text = $"${totalPrice}";
                //}
                //else
                //{
                //    totalPriceText.Text = "$0.00";
                //    purchaseButton.Enabled = false;
                //}
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

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Canciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Carrito carrito = new Carrito();
            carrito.ShowDialog();
        }
    }
}
