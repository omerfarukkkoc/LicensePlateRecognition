using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using openalprnet;
using AForge.Video;
using AForge.Video.DirectShow;
using MetroFramework.Forms;
using System.ComponentModel;
using System.Threading;

namespace licensePlateRecognition
{
    public partial class plakaAlgilamaSistemi : MetroForm
    {
        public FilterInfoCollection goruntulemeAygitlari;
        public VideoCaptureDevice kamera;
        public int gunlukPlakaSayisi = 0;

        public bool kapanmaKontrol;

        public string region = "eu";
        public string config_file = Path.Combine(AssemblyDirectory, "openalpr.conf");
        public string runtime_data_dir = Path.Combine(AssemblyDirectory, "runtime_data");



        public plakaAlgilamaSistemi()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(@"C:\Plaka Algılama Sistemi"))
                    Directory.CreateDirectory(@"C:\Plaka Algılama Sistemi");

                goruntulemeAygitlari = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo videocapturedevice in goruntulemeAygitlari)
                {
                    cbm_goruntulemeAygiti.Items.Add(videocapturedevice.Name);
                }
                cbm_goruntulemeAygiti.SelectedItem = 0;

                dosyadanOku();
                lbl_plakaSayisi.Text = gunlukPlakaSayisi.ToString();


                

                timer1.Enabled = false;
                timer1.Interval = 2000;
            }
            catch(Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Sistem Yüklenemedi \nSistemi Yeniden Başlatın \nSorun Devam Ederse Üreticinize Başvurun", "HATA!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void dosyadanOku()
        {
            try
            {
                string tarih = DateTime.Now.ToString("dd/MM/yyyy");
                string dosyaAdi = @"C:\Plaka Algılama Sistemi\" + tarih + ".txt";

                if (File.Exists(dosyaAdi) == true)
                {
                    string okunanSatir = "";
                    FileStream fs = new FileStream(dosyaAdi, FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    string okunan = sr.ReadLine();
                    while (okunan != null)
                    {
                        okunanSatir = okunan;
                        okunan = sr.ReadLine();
                    }
                    string[] parcalar;
                    parcalar = okunanSatir.Split('-');
                    gunlukPlakaSayisi = Convert.ToInt16(parcalar[0]);
                    sr.Close();
                    fs.Close();
                }
                else
                {
                    FileStream fs = new FileStream(dosyaAdi, FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(gunlukPlakaSayisi.ToString()+"-Plaka:-42OFK42     -Dogruluk:-%95,6");
                    sw.Flush();
                    sw.Close();
                    fs.Close();
                }
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Dosyadan Okuma Yapılamıyor \nSistemi Yeniden Başlatın \nSorun Devam Ederse Üreticinize Başvurun", "HATA!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btn_goruntuAl_Click(object sender, EventArgs e)
        {
            if (cbm_goruntulemeAygiti.Text != "")
            {
                kamera = new VideoCaptureDevice(goruntulemeAygitlari[cbm_goruntulemeAygiti.SelectedIndex].MonikerString);
                kamera.NewFrame += new NewFrameEventHandler(cam_NewFrame);
                kamera.Start();
                Thread.Sleep(1);
                timer1.Enabled = true;
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Lütfen Görüntü Aygıtı Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

        private void resetTools()
        {
            pb_bulunanPlaka.Image = null;
            lb_dogruluk.Items.Clear();
            lb_plaka.Items.Clear();
            txt_plaka.Clear();
            txt_dogruluk.Clear();
        }

        void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                kamera.DesiredFrameSize = new Size(pb_frame.Width, pb_frame.Height);
                Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
                pb_frame.Image = bmp;
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Görüntü Alınamıyor \nSistemi Yeniden Başlatın \nSorun Devam Ederse Üreticinize Başvurun", "HATA!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string AssemblyDirectory
        {
            get
            {
                var codeBase = Assembly.GetExecutingAssembly().CodeBase;
                var uri = new UriBuilder(codeBase);
                var path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }

        public Rectangle boundingRectangle(List<Point> points)
        {
            var minX = points.Min(p => p.X);
            var minY = points.Min(p => p.Y);
            var maxX = points.Max(p => p.X);
            var maxY = points.Max(p => p.Y);
            return new Rectangle(new Point(minX, minY), new Size(maxX - minX, maxY - minY));
        }

        public Image cropImage(Image img, Rectangle cropArea)
        {
            var bmpImage = new Bitmap(img);
            return bmpImage.Clone(cropArea, bmpImage.PixelFormat);
        }

        public static Bitmap combineImages(List<Image> images)
        {
            Bitmap finalImage = null;
            try
            {
                var width = 0;
                var height = 0;

                foreach (var bmp in images)
                {
                    width += bmp.Width;
                    height = bmp.Height > height ? bmp.Height : height;
                }

                finalImage = new Bitmap(width, height);

                using (var g = Graphics.FromImage(finalImage))
                {
                    g.Clear(Color.Black);

                    var offset = 0;
                    foreach (Bitmap image in images)
                    {
                        g.DrawImage(image,
                                    new Rectangle(offset, 0, image.Width, image.Height));
                        offset += image.Width;
                    }
                }
                return finalImage;
            }
            catch (Exception ex)
            {
                if (finalImage != null)
                    finalImage.Dispose();

                throw ex;
            }
            finally
            {
                foreach (var image in images)
                {
                    image.Dispose();
                }
            }
        }

        private void processingPlate(Bitmap bmp)
        {
            try
            {
                    
                using (var alpr = new AlprNet(region, config_file, runtime_data_dir))
                {
                    if (!alpr.IsLoaded())
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Kütüphane Yüklenemiyor \nSistemi Yeniden Başlatın \nSorun Devam Ederse Üreticinize Başvurun", "HATA!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if(bmp != null)
                    {
                        var results = alpr.Recognize(bmp);
                        var images = new List<Image>(results.Plates.Count());

                        foreach (var result in results.Plates)
                        {
                            var rect = boundingRectangle(result.PlatePoints);
                            var img = bmp;
                            var cropped = cropImage(img, rect);
                            images.Add(cropped);
                            lb_plaka.Items.Add("Plaka");
                            lb_dogruluk.Items.Add("Doğruluk");
                            foreach (var plate in result.TopNPlates)
                            {
                                lb_plaka.Items.Add(plate.Characters.PadRight(12).ToString());
                                lb_dogruluk.Items.Add("%" + plate.OverallConfidence.ToString("N1").PadRight(8)).ToString();
                            }

                            txt_plaka.Text = lb_plaka.Items[1].ToString();
                            txt_dogruluk.Text = lb_dogruluk.Items[1].ToString();

                            bool plakaVarYok = plakaVarmi(lb_plaka.Items[1].ToString());

                            if(!plakaVarYok)
                            {
                                gunlukPlakaSayisi++;
                                lbl_plakaSayisi.Text = gunlukPlakaSayisi.ToString();
                                dosyayaYaz(txt_plaka.Text, txt_dogruluk.Text);
                                lbl_kaydedildi.Text = "";
                                lbl_kaydedildi.Text = lb_plaka.Items[1].ToString()+ "Kaydedildi";
                            }
                        }

                        if (images.Any())
                        {
                            pb_bulunanPlaka.Image = combineImages(images);
                        }
                    }
                }    
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Plaka Algılanamıyor \nSistemi Yeniden Başlatın \nSorun Devam Ederse Üreticinize Başvurun", "HATA!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool plakaVarmi(string algilananPlaka)
        {
            bool plakaKontrol = false;
            try
            {
                string tarih = DateTime.Now.ToString("dd/MM/yyyy");
                string dosyaAdi = @"C:\Plaka Algılama Sistemi\" + tarih + ".txt";

                if (File.Exists(dosyaAdi) == true)
                {
                    FileStream fs = new FileStream(dosyaAdi, FileMode.Open, FileAccess.ReadWrite);
                    StreamReader sr = new StreamReader(fs);
                    string okunan = sr.ReadLine();
                    string oncekiOkunan;
                    string oncekiPlaka;
                    while (okunan != null)
                    {
                        oncekiOkunan = okunan;
                        okunan = sr.ReadLine();
                        string[] parcalar;
                        parcalar = oncekiOkunan.Split('-');
                        oncekiPlaka = parcalar[2];
                        if (oncekiPlaka == algilananPlaka)
                        {
                            plakaKontrol = true;
                        }
                    }
                    sr.Close();
                    fs.Close();

                }
                return plakaKontrol;
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Plaka Kontrolü Yapılamıyor \nSistemi Yeniden Başlatın \nSorun Devam Ederse Üreticinize Başvurun", "HATA!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return plakaKontrol;
            }
            
        }

        public void dosyayaYaz(string plaka, string dogruluk)
        {
            try
            {
                string tarih = DateTime.Now.ToString("dd/MM/yyyy");
                string dosyaAdi = @"C:\Plaka Algılama Sistemi\" + tarih + ".txt";


                if (File.Exists(dosyaAdi) == true)
                {
                    FileStream fs = new FileStream(dosyaAdi, FileMode.Append);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(gunlukPlakaSayisi.ToString()+"-Plaka:-"+plaka+"-Dogruluk:-"+dogruluk);
                    sw.Flush();
                    sw.Close();
                    fs.Close();
                }
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Dosyaya Yazma Yapılamıyor \nSistemi Yeniden Başlatın \nSorun Devam Ederse Üreticinize Başvurun", "HATA!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            anasayfa ana = new anasayfa();
            ana = new anasayfa();
            ana.ilkGiris = true;
            //this.Hide();
            ana.ShowDialog();
            if(kapanmaKontrol)
            {
                MetroFramework.MetroMessageBox.Show(this, "Sistem Kapatılıyor", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                ana.Close();
            }

            try
            {
                if (kamera != null)
                {
                    if (kamera.IsRunning)
                    {
                        kamera.Stop();
                    }
                }
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Sistem Kapatılamıyor \nSistemi Görev Yöneticisinden Kapatın \nSorun Devam Ederse Üreticinize Başvurun", "HATA!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txt_plaka_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_dogruluk_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            resetTools();
            Bitmap bmp = (Bitmap)pb_frame.Image;
            processingPlate(bmp);
        }
    }
}
