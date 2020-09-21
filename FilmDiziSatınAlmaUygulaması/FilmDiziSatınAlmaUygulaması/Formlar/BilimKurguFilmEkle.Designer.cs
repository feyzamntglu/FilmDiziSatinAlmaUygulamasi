namespace FilmDiziSatınAlmaUygulaması.Formlar
{
    partial class BilimKurguFilmEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BilimKurguFilmEkle));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmb_kategori = new System.Windows.Forms.ComboBox();
            this.cmn_dil = new System.Windows.Forms.ComboBox();
            this.txt_imdb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_tarih = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_filmİcerik = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_filmAdı = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(313, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 339);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.materialRaisedButton1.Location = new System.Drawing.Point(33, 469);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(205, 55);
            this.materialRaisedButton1.TabIndex = 18;
            this.materialRaisedButton1.Text = "EKLE";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // cmb_kategori
            // 
            this.cmb_kategori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_kategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_kategori.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cmb_kategori.FormattingEnabled = true;
            this.cmb_kategori.Items.AddRange(new object[] {
            "Bilim-Kurgu"});
            this.cmb_kategori.Location = new System.Drawing.Point(33, 409);
            this.cmb_kategori.Name = "cmb_kategori";
            this.cmb_kategori.Size = new System.Drawing.Size(205, 28);
            this.cmb_kategori.TabIndex = 17;
            this.cmb_kategori.Text = "Kategori";
            // 
            // cmn_dil
            // 
            this.cmn_dil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmn_dil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmn_dil.ForeColor = System.Drawing.Color.Gray;
            this.cmn_dil.FormattingEnabled = true;
            this.cmn_dil.Location = new System.Drawing.Point(33, 340);
            this.cmn_dil.Name = "cmn_dil";
            this.cmn_dil.Size = new System.Drawing.Size(205, 28);
            this.cmn_dil.TabIndex = 16;
            this.cmn_dil.Text = "Dil";
            // 
            // txt_imdb
            // 
            this.txt_imdb.Depth = 0;
            this.txt_imdb.Hint = "İMDB Puanı";
            this.txt_imdb.Location = new System.Drawing.Point(33, 286);
            this.txt_imdb.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_imdb.Name = "txt_imdb";
            this.txt_imdb.PasswordChar = '\0';
            this.txt_imdb.SelectedText = "";
            this.txt_imdb.SelectionLength = 0;
            this.txt_imdb.SelectionStart = 0;
            this.txt_imdb.Size = new System.Drawing.Size(220, 28);
            this.txt_imdb.TabIndex = 15;
            this.txt_imdb.UseSystemPasswordChar = false;
            this.txt_imdb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_imdb_KeyPress);
            // 
            // txt_tarih
            // 
            this.txt_tarih.Depth = 0;
            this.txt_tarih.Hint = "Çıkış Yılı";
            this.txt_tarih.Location = new System.Drawing.Point(33, 227);
            this.txt_tarih.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_tarih.Name = "txt_tarih";
            this.txt_tarih.PasswordChar = '\0';
            this.txt_tarih.SelectedText = "";
            this.txt_tarih.SelectionLength = 0;
            this.txt_tarih.SelectionStart = 0;
            this.txt_tarih.Size = new System.Drawing.Size(220, 28);
            this.txt_tarih.TabIndex = 14;
            this.txt_tarih.UseSystemPasswordChar = false;
            // 
            // txt_filmİcerik
            // 
            this.txt_filmİcerik.Depth = 0;
            this.txt_filmİcerik.Hint = "İçerik";
            this.txt_filmİcerik.Location = new System.Drawing.Point(33, 169);
            this.txt_filmİcerik.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_filmİcerik.Name = "txt_filmİcerik";
            this.txt_filmİcerik.PasswordChar = '\0';
            this.txt_filmİcerik.SelectedText = "";
            this.txt_filmİcerik.SelectionLength = 0;
            this.txt_filmİcerik.SelectionStart = 0;
            this.txt_filmİcerik.Size = new System.Drawing.Size(220, 28);
            this.txt_filmİcerik.TabIndex = 13;
            this.txt_filmİcerik.UseSystemPasswordChar = false;
            // 
            // txt_filmAdı
            // 
            this.txt_filmAdı.Depth = 0;
            this.txt_filmAdı.Hint = "Film Adı";
            this.txt_filmAdı.Location = new System.Drawing.Point(33, 101);
            this.txt_filmAdı.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_filmAdı.Name = "txt_filmAdı";
            this.txt_filmAdı.PasswordChar = '\0';
            this.txt_filmAdı.SelectedText = "";
            this.txt_filmAdı.SelectionLength = 0;
            this.txt_filmAdı.SelectionStart = 0;
            this.txt_filmAdı.Size = new System.Drawing.Size(220, 28);
            this.txt_filmAdı.TabIndex = 12;
            this.txt_filmAdı.UseSystemPasswordChar = false;
            // 
            // BilimKurguFilmEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 559);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.cmb_kategori);
            this.Controls.Add(this.cmn_dil);
            this.Controls.Add(this.txt_imdb);
            this.Controls.Add(this.txt_tarih);
            this.Controls.Add(this.txt_filmİcerik);
            this.Controls.Add(this.txt_filmAdı);
            this.Name = "BilimKurguFilmEkle";
            this.Text = "BilimKurguFilmEkle";
            this.Load += new System.EventHandler(this.BilimKurguFilmEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.ComboBox cmb_kategori;
        private System.Windows.Forms.ComboBox cmn_dil;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_imdb;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_tarih;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_filmİcerik;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_filmAdı;
    }
}