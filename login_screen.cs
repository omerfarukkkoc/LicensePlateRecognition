using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace licensePlateRecognition
{
    public partial class anasayfa : MetroForm
    {
        public anasayfa()
        {
            InitializeComponent();
        }
        public bool ilkGiris = false;
        public plakaAlgilamaSistemi pas = new plakaAlgilamaSistemi();

        public string kullaniciAdi = "admin";
        public string sifre = "lentus";

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if(!ilkGiris)
            {
                if (txt_kullaniciAdi.Text == kullaniciAdi && txt_sifre.Text == sifre)
                {
                    pas = new plakaAlgilamaSistemi();
                    this.Hide();
                    pas.ShowDialog();
                    this.Close();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Yanlış Kullanıcı Adı Ve Şifre", "HATA!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (txt_kullaniciAdi.Text == kullaniciAdi && txt_sifre.Text == sifre)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sistem Kapatılıyor", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Thread.Sleep(2);
                    this.Hide();
                    this.Close();
                    Application.Exit();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sistem Kapatılamıyor", "Yanlış Kullanıcı Adı Ve Şifre !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
