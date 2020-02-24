namespace MusicApp
{
    partial class Explorar
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
            this.Albums = new System.Windows.Forms.DataGridView();
            this.AlbumImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.AlbumNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlbumFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Albums)).BeginInit();
            this.SuspendLayout();
            // 
            // Albums
            // 
            this.Albums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Albums.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlbumImage,
            this.AlbumNombre,
            this.AlbumFecha});
            this.Albums.Location = new System.Drawing.Point(244, 73);
            this.Albums.Name = "Albums";
            this.Albums.Size = new System.Drawing.Size(326, 279);
            this.Albums.TabIndex = 0;
            this.Albums.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AlbumImage
            // 
            this.AlbumImage.HeaderText = "Image";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(619, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Explorar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Albums);
            this.Name = "Explorar";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Albums)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Albums;
        private System.Windows.Forms.DataGridViewImageColumn AlbumImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumFecha;
        private System.Windows.Forms.Button button1;
    }
}