namespace FilmDiziSatınAlmaUygulaması.Formlar
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.btn_listele = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_ekle = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_sil = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_güncelle = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_listele
            // 
            this.btn_listele.Depth = 0;
            this.btn_listele.Location = new System.Drawing.Point(28, 224);
            this.btn_listele.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Primary = true;
            this.btn_listele.Size = new System.Drawing.Size(403, 94);
            this.btn_listele.TabIndex = 0;
            this.btn_listele.Text = "listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Depth = 0;
            this.btn_ekle.Location = new System.Drawing.Point(28, 110);
            this.btn_ekle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Primary = true;
            this.btn_ekle.Size = new System.Drawing.Size(403, 95);
            this.btn_ekle.TabIndex = 1;
            this.btn_ekle.Text = "ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Depth = 0;
            this.btn_sil.Location = new System.Drawing.Point(28, 340);
            this.btn_sil.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Primary = true;
            this.btn_sil.Size = new System.Drawing.Size(403, 92);
            this.btn_sil.TabIndex = 2;
            this.btn_sil.Text = "sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.Depth = 0;
            this.btn_güncelle.Location = new System.Drawing.Point(28, 453);
            this.btn_güncelle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Primary = true;
            this.btn_güncelle.Size = new System.Drawing.Size(403, 100);
            this.btn_güncelle.TabIndex = 3;
            this.btn_güncelle.Text = "güncelle";
            this.btn_güncelle.UseVisualStyleBackColor = true;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(477, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(391, 443);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 609);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_güncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_listele);
            this.Name = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btn_listele;
        private MaterialSkin.Controls.MaterialRaisedButton btn_ekle;
        private MaterialSkin.Controls.MaterialRaisedButton btn_sil;
        private MaterialSkin.Controls.MaterialRaisedButton btn_güncelle;
    
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}