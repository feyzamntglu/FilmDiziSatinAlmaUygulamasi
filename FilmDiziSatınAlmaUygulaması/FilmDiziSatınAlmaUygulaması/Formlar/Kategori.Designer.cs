namespace FilmDiziSatınAlmaUygulaması.Formlar
{
    partial class Kategori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kategori));
            this.btn_bilimKurgu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_komedi = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_romantik = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_bilimKurgu
            // 
            this.btn_bilimKurgu.Depth = 0;
            this.btn_bilimKurgu.Location = new System.Drawing.Point(38, 102);
            this.btn_bilimKurgu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_bilimKurgu.Name = "btn_bilimKurgu";
            this.btn_bilimKurgu.Primary = true;
            this.btn_bilimKurgu.Size = new System.Drawing.Size(257, 311);
            this.btn_bilimKurgu.TabIndex = 0;
            this.btn_bilimKurgu.Text = "Bilim-Kurgu filmi Ekle";
            this.btn_bilimKurgu.UseVisualStyleBackColor = true;
            this.btn_bilimKurgu.Click += new System.EventHandler(this.btn_bilimKurgu_Click);
            // 
            // btn_komedi
            // 
            this.btn_komedi.Depth = 0;
            this.btn_komedi.Location = new System.Drawing.Point(341, 102);
            this.btn_komedi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_komedi.Name = "btn_komedi";
            this.btn_komedi.Primary = true;
            this.btn_komedi.Size = new System.Drawing.Size(270, 311);
            this.btn_komedi.TabIndex = 1;
            this.btn_komedi.Text = "Komedi Filmi Ekle";
            this.btn_komedi.UseVisualStyleBackColor = true;
            this.btn_komedi.Click += new System.EventHandler(this.btn_komedi_Click);
            // 
            // btn_romantik
            // 
            this.btn_romantik.Depth = 0;
            this.btn_romantik.Location = new System.Drawing.Point(651, 102);
            this.btn_romantik.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_romantik.Name = "btn_romantik";
            this.btn_romantik.Primary = true;
            this.btn_romantik.Size = new System.Drawing.Size(260, 311);
            this.btn_romantik.TabIndex = 2;
            this.btn_romantik.Text = "Romantik film ekle";
            this.btn_romantik.UseVisualStyleBackColor = true;
            this.btn_romantik.Click += new System.EventHandler(this.btn_romantik_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-15, 436);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(949, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Kategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 590);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_romantik);
            this.Controls.Add(this.btn_komedi);
            this.Controls.Add(this.btn_bilimKurgu);
            this.Name = "Kategori";
            this.Load += new System.EventHandler(this.Kategori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btn_bilimKurgu;
        private MaterialSkin.Controls.MaterialRaisedButton btn_komedi;
        private MaterialSkin.Controls.MaterialRaisedButton btn_romantik;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}