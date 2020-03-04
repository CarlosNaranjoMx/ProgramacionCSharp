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

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //string name = Albums.SelectedRows[0].Cells["Album"].Value.ToString();
            //using (StreamWriter sw = File.AppendText(@"..\..\WriteText.txt"))
            //{
            //    sw.WriteLine(name);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
