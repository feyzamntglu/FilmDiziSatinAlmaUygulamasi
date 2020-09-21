namespace FilmDiziSatınAlmaUygulaması.Formlar
{
    partial class FilmGüncelle
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
            this.materialRaisedButtonGüncelle = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmb_kategorisi = new System.Windows.Forms.ComboBox();
            this.cmn_dili = new System.Windows.Forms.ComboBox();
            this.txt_imdbPuani = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_cikiisYili = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_filmİcer = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_filmAd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.film_id = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // materialRaisedButtonGüncelle
            // 
            this.materialRaisedButtonGüncelle.Depth = 0;
            this.materialRaisedButtonGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.materialRaisedButtonGüncelle.Location = new System.Drawing.Point(58, 495);
            this.materialRaisedButtonGüncelle.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonGüncelle.Name = "materialRaisedButtonGüncelle";
            this.materialRaisedButtonGüncelle.Primary = true;
            this.materialRaisedButtonGüncelle.Size = new System.Drawing.Size(220, 55);
            this.materialRaisedButtonGüncelle.TabIndex = 20;
            this.materialRaisedButtonGüncelle.Text = "GÜNCELLLE";
            this.materialRaisedButtonGüncelle.UseVisualStyleBackColor = true;
            this.materialRaisedButtonGüncelle.Click += new System.EventHandler(this.materialRaisedButtonGüncelle_Click);
            // 
            // cmb_kategorisi
            // 
            this.cmb_kategorisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_kategorisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_kategorisi.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cmb_kategorisi.FormattingEnabled = true;
            this.cmb_kategorisi.Location = new System.Drawing.Point(58, 437);
            this.cmb_kategorisi.Name = "cmb_kategorisi";
            this.cmb_kategorisi.Size = new System.Drawing.Size(205, 28);
            this.cmb_kategorisi.TabIndex = 19;
            this.cmb_kategorisi.Text = "Kategori";
            this.cmb_kategorisi.SelectedIndexChanged += new System.EventHandler(this.cmb_kategorisi_SelectedIndexChanged);
            // 
            // cmn_dili
            // 
            this.cmn_dili.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmn_dili.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmn_dili.ForeColor = System.Drawing.Color.Gray;
            this.cmn_dili.FormattingEnabled = true;
            this.cmn_dili.Location = new System.Drawing.Point(58, 383);
            this.cmn_dili.Name = "cmn_dili";
            this.cmn_dili.Size = new System.Drawing.Size(205, 28);
            this.cmn_dili.TabIndex = 18;
            this.cmn_dili.Text = "Dil";
            this.cmn_dili.SelectedIndexChanged += new System.EventHandler(this.cmn_dili_SelectedIndexChanged);
            // 
            // txt_imdbPuani
            // 
            this.txt_imdbPuani.Depth = 0;
            this.txt_imdbPuani.Hint = "İMDB Puanı";
            this.txt_imdbPuani.Location = new System.Drawing.Point(58, 337);
            this.txt_imdbPuani.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_imdbPuani.Name = "txt_imdbPuani";
            this.txt_imdbPuani.PasswordChar = '\0';
            this.txt_imdbPuani.SelectedText = "";
            this.txt_imdbPuani.SelectionLength = 0;
            this.txt_imdbPuani.SelectionStart = 0;
            this.txt_imdbPuani.Size = new System.Drawing.Size(220, 28);
            this.txt_imdbPuani.TabIndex = 17;
            this.txt_imdbPuani.UseSystemPasswordChar = false;
            // 
            // txt_cikiisYili
            // 
            this.txt_cikiisYili.Depth = 0;
            this.txt_cikiisYili.Hint = "Çıkış Yılı";
            this.txt_cikiisYili.Location = new System.Drawing.Point(58, 278);
            this.txt_cikiisYili.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_cikiisYili.Name = "txt_cikiisYili";
            this.txt_cikiisYili.PasswordChar = '\0';
            this.txt_cikiisYili.SelectedText = "";
            this.txt_cikiisYili.SelectionLength = 0;
            this.txt_cikiisYili.SelectionStart = 0;
            this.txt_cikiisYili.Size = new System.Drawing.Size(220, 28);
            this.txt_cikiisYili.TabIndex = 16;
            this.txt_cikiisYili.UseSystemPasswordChar = false;
            // 
            // txt_filmİcer
            // 
            this.txt_filmİcer.Depth = 0;
            this.txt_filmİcer.Hint = "İçerik";
            this.txt_filmİcer.Location = new System.Drawing.Point(58, 225);
            this.txt_filmİcer.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_filmİcer.Name = "txt_filmİcer";
            this.txt_filmİcer.PasswordChar = '\0';
            this.txt_filmİcer.SelectedText = "";
            this.txt_filmİcer.SelectionLength = 0;
            this.txt_filmİcer.SelectionStart = 0;
            this.txt_filmİcer.Size = new System.Drawing.Size(220, 28);
            this.txt_filmİcer.TabIndex = 15;
            this.txt_filmİcer.UseSystemPasswordChar = false;
            // 
            // txt_filmAd
            // 
            this.txt_filmAd.Depth = 0;
            this.txt_filmAd.Hint = "Film Adı";
            this.txt_filmAd.Location = new System.Drawing.Point(58, 167);
            this.txt_filmAd.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_filmAd.Name = "txt_filmAd";
            this.txt_filmAd.PasswordChar = '\0';
            this.txt_filmAd.SelectedText = "";
            this.txt_filmAd.SelectionLength = 0;
            this.txt_filmAd.SelectionStart = 0;
            this.txt_filmAd.Size = new System.Drawing.Size(220, 28);
            this.txt_filmAd.TabIndex = 14;
            this.txt_filmAd.UseSystemPasswordChar = false;
            // 
            // film_id
            // 
            this.film_id.Depth = 0;
            this.film_id.Hint = "Film İd";
            this.film_id.Location = new System.Drawing.Point(58, 122);
            this.film_id.MouseState = MaterialSkin.MouseState.HOVER;
            this.film_id.Name = "film_id";
            this.film_id.PasswordChar = '\0';
            this.film_id.SelectedText = "";
            this.film_id.SelectionLength = 0;
            this.film_id.SelectionStart = 0;
            this.film_id.Size = new System.Drawing.Size(220, 28);
            this.film_id.TabIndex = 21;
            this.film_id.UseSystemPasswordChar = false;
            this.film_id.Click += new System.EventHandler(this.film_id_Click);
            // 
            // FilmGüncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 595);
            this.Controls.Add(this.film_id);
            this.Controls.Add(this.materialRaisedButtonGüncelle);
            this.Controls.Add(this.cmb_kategorisi);
            this.Controls.Add(this.cmn_dili);
            this.Controls.Add(this.txt_imdbPuani);
            this.Controls.Add(this.txt_cikiisYili);
            this.Controls.Add(this.txt_filmİcer);
            this.Controls.Add(this.txt_filmAd);
            this.Name = "FilmGüncelle";
            this.Text = "FilmGüncelle";
            this.Load += new System.EventHandler(this.FilmGüncelle_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonGüncelle;
        private System.Windows.Forms.ComboBox cmb_kategorisi;
        private System.Windows.Forms.ComboBox cmn_dili;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_imdbPuani;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_cikiisYili;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_filmİcer;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_filmAd;
        private MaterialSkin.Controls.MaterialSingleLineTextField film_id;
    }
}