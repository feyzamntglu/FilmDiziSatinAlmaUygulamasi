namespace FilmDiziSatınAlmaUygulaması.Formlar
{
    partial class AdminFilmListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminFilmListele));
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmb_sec = new System.Windows.Forms.ComboBox();
            this.datagridFilm = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_film = new System.Windows.Forms.ComboBox();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.materialRaisedButton1.Location = new System.Drawing.Point(257, 139);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(144, 40);
            this.materialRaisedButton1.TabIndex = 13;
            this.materialRaisedButton1.Text = "Filtrele";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(458, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // cmb_sec
            // 
            this.cmb_sec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_sec.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sec.FormattingEnabled = true;
            this.cmb_sec.Location = new System.Drawing.Point(32, 242);
            this.cmb_sec.Name = "cmb_sec";
            this.cmb_sec.Size = new System.Drawing.Size(369, 32);
            this.cmb_sec.TabIndex = 11;
            this.cmb_sec.Visible = false;
            this.cmb_sec.SelectedIndexChanged += new System.EventHandler(this.cmb_sec_SelectedIndexChanged_1);
            // 
            // datagridFilm
            // 
            this.datagridFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridFilm.Location = new System.Drawing.Point(1, 318);
            this.datagridFilm.Name = "datagridFilm";
            this.datagridFilm.RowTemplate.Height = 24;
            this.datagridFilm.Size = new System.Drawing.Size(883, 302);
            this.datagridFilm.TabIndex = 10;
            this.datagridFilm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridFilm_CellClick_1);
            this.datagridFilm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridFilm_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(39, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Film Listele";
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
            this.cmb_film.Location = new System.Drawing.Point(32, 139);
            this.cmb_film.Name = "cmb_film";
            this.cmb_film.Size = new System.Drawing.Size(192, 32);
            this.cmb_film.TabIndex = 8;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.materialRaisedButton2.Location = new System.Drawing.Point(257, 185);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(144, 40);
            this.materialRaisedButton2.TabIndex = 14;
            this.materialRaisedButton2.Text = "SİL";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // AdminFilmListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 620);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmb_sec);
            this.Controls.Add(this.datagridFilm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_film);
            this.Name = "AdminFilmListele";
            this.Load += new System.EventHandler(this.AdminFilmListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmb_sec;
        private System.Windows.Forms.DataGridView datagridFilm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_film;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
    }
}