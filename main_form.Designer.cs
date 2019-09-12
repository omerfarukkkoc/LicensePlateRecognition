namespace licensePlateRecognition
{
    partial class plakaAlgilamaSistemi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(plakaAlgilamaSistemi));
            this.lb_plaka = new System.Windows.Forms.ListBox();
            this.pb_frame = new System.Windows.Forms.PictureBox();
            this.pb_bulunanPlaka = new System.Windows.Forms.PictureBox();
            this.lb_dogruluk = new System.Windows.Forms.ListBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_plaka = new MetroFramework.Controls.MetroTextBox();
            this.txt_dogruluk = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btn_goruntuAl = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cbm_goruntulemeAygiti = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lbl_plakaSayisi = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_kaydedildi = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_frame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bulunanPlaka)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_plaka
            // 
            this.lb_plaka.FormattingEnabled = true;
            this.lb_plaka.Location = new System.Drawing.Point(471, 110);
            this.lb_plaka.Name = "lb_plaka";
            this.lb_plaka.Size = new System.Drawing.Size(98, 173);
            this.lb_plaka.TabIndex = 0;
            // 
            // pb_frame
            // 
            this.pb_frame.Location = new System.Drawing.Point(12, 176);
            this.pb_frame.Name = "pb_frame";
            this.pb_frame.Size = new System.Drawing.Size(403, 292);
            this.pb_frame.TabIndex = 1;
            this.pb_frame.TabStop = false;
            // 
            // pb_bulunanPlaka
            // 
            this.pb_bulunanPlaka.Location = new System.Drawing.Point(471, 316);
            this.pb_bulunanPlaka.Name = "pb_bulunanPlaka";
            this.pb_bulunanPlaka.Size = new System.Drawing.Size(211, 94);
            this.pb_bulunanPlaka.TabIndex = 2;
            this.pb_bulunanPlaka.TabStop = false;
            // 
            // lb_dogruluk
            // 
            this.lb_dogruluk.FormattingEnabled = true;
            this.lb_dogruluk.Location = new System.Drawing.Point(592, 110);
            this.lb_dogruluk.Name = "lb_dogruluk";
            this.lb_dogruluk.Size = new System.Drawing.Size(90, 173);
            this.lb_dogruluk.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(471, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(158, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Bulunan Olası Plakalar";
            // 
            // txt_plaka
            // 
            this.txt_plaka.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txt_plaka.Lines = new string[0];
            this.txt_plaka.Location = new System.Drawing.Point(592, 416);
            this.txt_plaka.MaxLength = 32767;
            this.txt_plaka.Name = "txt_plaka";
            this.txt_plaka.PasswordChar = '\0';
            this.txt_plaka.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_plaka.SelectedText = "";
            this.txt_plaka.Size = new System.Drawing.Size(90, 23);
            this.txt_plaka.TabIndex = 12;
            this.txt_plaka.UseSelectable = true;
            this.txt_plaka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_plaka_KeyPress);
            // 
            // txt_dogruluk
            // 
            this.txt_dogruluk.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txt_dogruluk.Lines = new string[0];
            this.txt_dogruluk.Location = new System.Drawing.Point(592, 445);
            this.txt_dogruluk.MaxLength = 32767;
            this.txt_dogruluk.Name = "txt_dogruluk";
            this.txt_dogruluk.PasswordChar = '\0';
            this.txt_dogruluk.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_dogruluk.SelectedText = "";
            this.txt_dogruluk.Size = new System.Drawing.Size(90, 23);
            this.txt_dogruluk.TabIndex = 12;
            this.txt_dogruluk.UseSelectable = true;
            this.txt_dogruluk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dogruluk_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(471, 294);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Plaka";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(12, 98);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(177, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Görüntü Aygıtını Seçiniz :";
            // 
            // btn_goruntuAl
            // 
            this.btn_goruntuAl.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_goruntuAl.Location = new System.Drawing.Point(12, 126);
            this.btn_goruntuAl.Name = "btn_goruntuAl";
            this.btn_goruntuAl.Size = new System.Drawing.Size(403, 23);
            this.btn_goruntuAl.TabIndex = 14;
            this.btn_goruntuAl.Text = "Görüntü Al";
            this.btn_goruntuAl.UseSelectable = true;
            this.btn_goruntuAl.Click += new System.EventHandler(this.btn_goruntuAl_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(471, 420);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(103, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Bulunan Plaka";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(471, 446);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(112, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Doğruluk Oranı";
            // 
            // cbm_goruntulemeAygiti
            // 
            this.cbm_goruntulemeAygiti.FormattingEnabled = true;
            this.cbm_goruntulemeAygiti.ItemHeight = 23;
            this.cbm_goruntulemeAygiti.Location = new System.Drawing.Point(200, 91);
            this.cbm_goruntulemeAygiti.Name = "cbm_goruntulemeAygiti";
            this.cbm_goruntulemeAygiti.Size = new System.Drawing.Size(215, 29);
            this.cbm_goruntulemeAygiti.TabIndex = 15;
            this.cbm_goruntulemeAygiti.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(488, 54);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(150, 19);
            this.metroLabel6.TabIndex = 17;
            this.metroLabel6.Text = "Toplam Plaka Sayısı: ";
            // 
            // lbl_plakaSayisi
            // 
            this.lbl_plakaSayisi.AutoSize = true;
            this.lbl_plakaSayisi.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_plakaSayisi.Location = new System.Drawing.Point(627, 54);
            this.lbl_plakaSayisi.Name = "lbl_plakaSayisi";
            this.lbl_plakaSayisi.Size = new System.Drawing.Size(0, 0);
            this.lbl_plakaSayisi.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 19;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel8.Location = new System.Drawing.Point(12, 498);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(371, 30);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel8.TabIndex = 21;
            this.metroLabel8.Text = "2018 - Tüm Hakları Ömer Faruk KOÇ\'a Aittir - omerfarukkoc42@gmail.com\r\n";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_kaydedildi
            // 
            this.lbl_kaydedildi.AutoSize = true;
            this.lbl_kaydedildi.BackColor = System.Drawing.Color.White;
            this.lbl_kaydedildi.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_kaydedildi.Location = new System.Drawing.Point(508, 474);
            this.lbl_kaydedildi.Name = "lbl_kaydedildi";
            this.lbl_kaydedildi.Size = new System.Drawing.Size(0, 0);
            this.lbl_kaydedildi.Style = MetroFramework.MetroColorStyle.Blue;
            this.lbl_kaydedildi.TabIndex = 22;
            this.lbl_kaydedildi.UseStyleColors = true;
            // 
            // plakaAlgilamaSistemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 513);
            this.Controls.Add(this.lbl_kaydedildi);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_plakaSayisi);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.cbm_goruntulemeAygiti);
            this.Controls.Add(this.btn_goruntuAl);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txt_dogruluk);
            this.Controls.Add(this.txt_plaka);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pb_bulunanPlaka);
            this.Controls.Add(this.pb_frame);
            this.Controls.Add(this.lb_dogruluk);
            this.Controls.Add(this.lb_plaka);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "plakaAlgilamaSistemi";
            this.Resizable = false;
            this.Text = "Plaka Algılama Sistemi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pb_frame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bulunanPlaka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_plaka;
        private System.Windows.Forms.PictureBox pb_frame;
        private System.Windows.Forms.PictureBox pb_bulunanPlaka;
        private System.Windows.Forms.ListBox lb_dogruluk;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_plaka;
        private MetroFramework.Controls.MetroTextBox txt_dogruluk;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btn_goruntuAl;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cbm_goruntulemeAygiti;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel lbl_plakaSayisi;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel lbl_kaydedildi;
    }
}

