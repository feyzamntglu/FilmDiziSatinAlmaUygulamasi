namespace FilmDiziSatınAlmaUygulaması
{
    partial class FilmListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmListele));
            this.cmb_film = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datagridFilm = new System.Windows.Forms.DataGridView();
            this.cmb_sec = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.datagridFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_film
            // 
            this.cmb_film.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_film.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_film.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmb_film.FormattingEnabled = true;
            this.cmb_film.Items.AddRange(new object[] {
            "İMDP Puanı Artan",
            "İMDP Puanı Azalan",
            "Kategori",
            "Oyuncu",
            "Dil",
            "Tüm Filmler"});
            this.cmb_film.Location = new System.Drawing.Point(35, 139);
            this.cmb_film.Name = "cmb_film";
            this.cmb_film.Size = new System.Drawing.Size(192, 32);
            this.cmb_film.TabIndex = 1;
            this.cmb_film.SelectedIndexChanged += new System.EventHandler(this.cmb_film_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(30, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Film Listele";
            // 
            // datagridFilm
            // 
            this.datagridFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridFilm.Location = new System.Drawing.Point(1, 298);
            this.datagridFilm.Name = "datagridFilm";
            this.datagridFilm.RowTemplate.Height = 24;
            this.datagridFilm.Size = new System.Drawing.Size(808, 302);
            this.datagridFilm.TabIndex = 3;
            this.datagridFilm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridFilm_CellClick);
            this.datagridFilm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridFilm_CellContentClick);
            // 
            // cmb_sec
            // 
            this.cmb_sec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_sec.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sec.FormattingEnabled = true;
            this.cmb_sec.Location = new System.Drawing.Point(35, 203);
            this.cmb_sec.Name = "cmb_sec";
            this.cmb_sec.Size = new System.Drawing.Size(369, 32);
            this.cmb_sec.TabIndex = 5;
            this.cmb_sec.Visible = false;
            this.cmb_sec.SelectedIndexChanged += new System.EventHandler(this.cmb_sec_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(466, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.materialRaisedButton1.Location = new System.Drawing.Point(260, 139);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(144, 40);
            this.materialRaisedButton1.TabIndex = 7;
            this.materialRaisedButton1.Text = "Filtrele";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // FilmListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 596);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmb_sec);
            this.Controls.Add(this.datagridFilm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_film);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FilmListele";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_film;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagridFilm;
        private System.Windows.Forms.ComboBox cmb_sec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}