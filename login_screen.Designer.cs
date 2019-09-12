namespace licensePlateRecognition
{
    partial class anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.txt_kullaniciAdi = new MetroFramework.Controls.MetroTextBox();
            this.txt_sifre = new MetroFramework.Controls.MetroTextBox();
            this.btn_giris = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // txt_kullaniciAdi
            // 
            this.txt_kullaniciAdi.Lines = new string[0];
            this.txt_kullaniciAdi.Location = new System.Drawing.Point(136, 73);
            this.txt_kullaniciAdi.MaxLength = 32767;
            this.txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            this.txt_kullaniciAdi.PasswordChar = '\0';
            this.txt_kullaniciAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_kullaniciAdi.SelectedText = "";
            this.txt_kullaniciAdi.Size = new System.Drawing.Size(97, 23);
            this.txt_kullaniciAdi.TabIndex = 0;
            this.txt_kullaniciAdi.UseSelectable = true;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Lines = new string[0];
            this.txt_sifre.Location = new System.Drawing.Point(136, 103);
            this.txt_sifre.MaxLength = 32767;
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '●';
            this.txt_sifre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_sifre.SelectedText = "";
            this.txt_sifre.Size = new System.Drawing.Size(97, 23);
            this.txt_sifre.TabIndex = 1;
            this.txt_sifre.UseSelectable = true;
            this.txt_sifre.UseSystemPasswordChar = true;
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(136, 133);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(97, 23);
            this.btn_giris.TabIndex = 2;
            this.btn_giris.Text = "Giriş";
            this.btn_giris.UseSelectable = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(44, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(86, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Kullanıcı Adı :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(88, 107);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Şifre :";
            // 
            // anasayfa
            // 
            this.AcceptButton = this.btn_giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 193);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kullaniciAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "anasayfa";
            this.Resizable = false;
            this.Text = "Plaka Algılama Sistemi - Giriş";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_kullaniciAdi;
        private MetroFramework.Controls.MetroTextBox txt_sifre;
        private MetroFramework.Controls.MetroButton btn_giris;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}