namespace FilmDiziSatınAlmaUygulaması
{
    partial class GirisForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
            this.kullanıcı_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.parola_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.giris_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.htırla_chck = new MaterialSkin.Controls.MaterialCheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kullanıcı_txt
            // 
            this.kullanıcı_txt.Depth = 0;
            this.kullanıcı_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcı_txt.Hint = "Kullanıcı Adı";
            this.kullanıcı_txt.Location = new System.Drawing.Point(52, 416);
            this.kullanıcı_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.kullanıcı_txt.Name = "kullanıcı_txt";
            this.kullanıcı_txt.PasswordChar = '\0';
            this.kullanıcı_txt.SelectedText = "";
            this.kullanıcı_txt.SelectionLength = 0;
            this.kullanıcı_txt.SelectionStart = 0;
            this.kullanıcı_txt.Size = new System.Drawing.Size(370, 28);
            this.kullanıcı_txt.TabIndex = 0;
            this.kullanıcı_txt.UseSystemPasswordChar = false;
            // 
            // parola_txt
            // 
            this.parola_txt.Depth = 0;
            this.parola_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parola_txt.Hint = "Parola";
            this.parola_txt.Location = new System.Drawing.Point(52, 469);
            this.parola_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.parola_txt.Name = "parola_txt";
            this.parola_txt.PasswordChar = '*';
            this.parola_txt.SelectedText = "";
            this.parola_txt.SelectionLength = 0;
            this.parola_txt.SelectionStart = 0;
            this.parola_txt.Size = new System.Drawing.Size(370, 28);
            this.parola_txt.TabIndex = 1;
            this.parola_txt.UseSystemPasswordChar = false;
            // 
            // giris_btn
            // 
            this.giris_btn.Depth = 0;
            this.giris_btn.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giris_btn.Location = new System.Drawing.Point(267, 527);
            this.giris_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.giris_btn.Name = "giris_btn";
            this.giris_btn.Primary = true;
            this.giris_btn.Size = new System.Drawing.Size(155, 49);
            this.giris_btn.TabIndex = 2;
            this.giris_btn.Text = "Giriş Yap";
            this.giris_btn.UseVisualStyleBackColor = true;
            this.giris_btn.Click += new System.EventHandler(this.giris_btn_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(43, 348);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(370, 1);
            this.materialDivider1.TabIndex = 3;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // htırla_chck
            // 
            this.htırla_chck.AutoSize = true;
            this.htırla_chck.BackColor = System.Drawing.Color.Transparent;
            this.htırla_chck.Depth = 0;
            this.htırla_chck.Font = new System.Drawing.Font("Roboto", 10F);
            this.htırla_chck.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.htırla_chck.Location = new System.Drawing.Point(52, 527);
            this.htırla_chck.Margin = new System.Windows.Forms.Padding(0);
            this.htırla_chck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.htırla_chck.MouseState = MaterialSkin.MouseState.HOVER;
            this.htırla_chck.Name = "htırla_chck";
            this.htırla_chck.Ripple = true;
            this.htırla_chck.Size = new System.Drawing.Size(121, 30);
            this.htırla_chck.TabIndex = 4;
            this.htırla_chck.Text = "Beni Hatırla";
            this.htırla_chck.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(150, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(159, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Oturum Aç";
            // 
            // GirisForm
            // 
            this.AcceptButton = this.giris_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 637);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.htırla_chck);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.giris_btn);
            this.Controls.Add(this.parola_txt);
            this.Controls.Add(this.kullanıcı_txt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField kullanıcı_txt;
        private MaterialSkin.Controls.MaterialSingleLineTextField parola_txt;
        private MaterialSkin.Controls.MaterialRaisedButton giris_btn;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialCheckBox htırla_chck;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

