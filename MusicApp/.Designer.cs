namespace MusicApp
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.radioCancion = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Canciones = new System.Windows.Forms.DataGridView();
            this.Albums = new System.Windows.Forms.DataGridView();
            this.AlbumImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.AlbumNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlbumFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrito = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AlbumCarrito = new System.Windows.Forms.DataGridViewButtonColumn();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Play = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Canciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Albums)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox4);
            this.splitContainer1.Panel1.Controls.Add(this.radioCancion);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel1.Controls.Add(this.radioButton2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Canciones);
            this.splitContainer1.Panel2.Controls.Add(this.Albums);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1191, 514);
            this.splitContainer1.SplitterDistance = 396;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(85, 244);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(106, 20);
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click_1);
            // 
            // radioCancion
            // 
            this.radioCancion.AutoSize = true;
            this.radioCancion.Location = new System.Drawing.Point(29, 159);
            this.radioCancion.Name = "radioCancion";
            this.radioCancion.Size = new System.Drawing.Size(75, 17);
            this.radioCancion.TabIndex = 26;
            this.radioCancion.TabStop = true;
            this.radioCancion.Text = "Canciones";
            this.radioCancion.UseVisualStyleBackColor = true;
            this.radioCancion.CheckedChanged += new System.EventHandler(this.radioCancion_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 82);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-18, -11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(359, 95);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(29, 113);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(54, 17);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Album";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Canciones
            // 
            this.Canciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Canciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Album,
            this.dataGridViewTextBoxColumn2,
            this.Artist,
            this.dataGridViewButtonColumn1,
            this.Play});
            this.Canciones.Location = new System.Drawing.Point(17, 0);
            this.Canciones.Name = "Canciones";
            this.Canciones.Size = new System.Drawing.Size(647, 483);
            this.Canciones.TabIndex = 10;
            this.Canciones.Visible = false;
            this.Canciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Canciones_CellContentClick);
            // 
            // Albums
            // 
            this.Albums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Albums.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlbumImage,
            this.AlbumNombre,
            this.AlbumFecha,
            this.Carrito,
            this.AlbumCarrito});
            this.Albums.Location = new System.Drawing.Point(17, 12);
            this.Albums.Name = "Albums";
            this.Albums.Size = new System.Drawing.Size(533, 483);
            this.Albums.TabIndex = 9;
            this.Albums.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Albums_CellContentClick);
            // 
            // AlbumImage
            // 
            this.AlbumImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AlbumImage.HeaderText = "Image";
            this.AlbumImage.MinimumWidth = 20;
            this.AlbumImage.Name = "AlbumImage";
            this.AlbumImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AlbumImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AlbumImage.Width = 61;
            // 
            // AlbumNombre
            // 
            this.AlbumNombre.HeaderText = "Album";
            this.AlbumNombre.Name = "AlbumNombre";
            // 
            // AlbumFecha
            // 
            this.AlbumFecha.HeaderText = "Fecha";
            this.AlbumFecha.Name = "AlbumFecha";
            // 
            // Carrito
            // 
            this.Carrito.HeaderText = "Seleccionar";
            this.Carrito.Name = "Carrito";
            this.Carrito.Text = "Seleccionar";
            this.Carrito.UseColumnTextForButtonValue = true;
            // 
            // AlbumCarrito
            // 
            this.AlbumCarrito.HeaderText = "Carrito";
            this.AlbumCarrito.Name = "AlbumCarrito";
            this.AlbumCarrito.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AlbumCarrito.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AlbumCarrito.Text = "Añadir al Carrito";
            this.AlbumCarrito.UseColumnTextForButtonValue = true;
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Title";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Album
            // 
            this.Album.HeaderText = "Album";
            this.Album.Name = "Album";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Artist
            // 
            this.Artist.HeaderText = "Artist";
            this.Artist.Name = "Artist";
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Carrito";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Text = "Carrito";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // Play
            // 
            this.Play.HeaderText = "Preview";
            this.Play.Name = "Play";
            this.Play.Text = "Start/Stop";
            this.Play.UseColumnTextForButtonValue = true;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 514);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Canciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Albums)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataGridView Albums;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView Canciones;
        private System.Windows.Forms.RadioButton radioCancion;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridViewImageColumn AlbumImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumFecha;
        private System.Windows.Forms.DataGridViewButtonColumn Carrito;
        private System.Windows.Forms.DataGridViewButtonColumn AlbumCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Album;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn Play;
    }
}

