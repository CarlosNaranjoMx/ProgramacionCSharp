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
    public partial class Carrito : Form
    {
        public Carrito()
        {
            InitializeComponent();
        }

        private void Carrito_Load(object sender, EventArgs e)
        {
            trackBindingSource.DataSource = Program.carrito;
            if (trackBindingSource.Count > 0)
            {
                var totalPrice = Program.carrito.Select(t => t.Price).Aggregate((p1, p2) => p1 + p2);
                totalPriceText.Text = $"${totalPrice}";
                purchaseButton.Enabled = true;
            }
            // Crear Una columna con boton
            var bc = new DataGridViewButtonColumn();
            bc.HeaderText = "Eliminar";
            bc.Text = "X";
            bc.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(1, bc);
        }

        private void trackBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        // Botones de la tabla
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                trackBindingSource.RemoveAt(e.RowIndex);
                if (trackBindingSource.Count > 0)
                {
                    var totalPrice = Program.carrito.Select(t => t.Price).Aggregate((p1, p2) => p1 + p2);
                    totalPriceText.Text = $"${totalPrice}";
                }
                else
                {
                    totalPriceText.Text = "$0.00";
                    purchaseButton.Enabled = false;
                }
            }
        }

        // Creacion del Ticket
        private void purchaseButton_Click(object sender, EventArgs e)
        {
            purchaseButton.Enabled = false;

            if (trackBindingSource.Count > 0)
            {
                var total = 0.0;
                var now = DateTime.Now;

                var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                var filePath = Path.Combine(desktopPath, $"Compra_{(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds}.txt");
                FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                sw.Write($"Compra de {now}\n");
                sw.Write("--------------------------\n");
                foreach(var t in trackBindingSource)
                {
                    var track = t as Track;
                    total += track.Price;
                    sw.Write($"1\t {track.Title}, de {track.Artist.Name}\t ${track.Price}\n");
                }
                sw.Write("--------------------------\n");
                sw.Write($"Total: ${total}\n");
                sw.Write($"Compra de {now}\n");

                sw.Flush();
                
                fs.Close();

                trackBindingSource.DataSource = null;
                Program.carrito.Clear();

                MessageBox.Show("Compra registrada en el escritorio");
            }

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
