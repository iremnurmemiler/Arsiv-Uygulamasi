using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using DevExpress.XtraEditors;

namespace Arsiv
{
    public partial class FotografEkleme : DevExpress.XtraEditors.XtraForm
    {
        public FotografEkleme()
        {
            InitializeComponent();

        }
        public FotografEkleme(int _rid)
        {
            InitializeComponent();
            rid = _rid;
        }
        int rid = 0;
        public bool IsDirty = false;
        Sql_Servis servis = new Sql_Servis();
        private void FotografEkleme_Load(object sender, EventArgs e)
        {
            fnYetkiler();
            fnBilgileriGetir();

        }
        private void fnIslemler(Islemler islem)
        {
            try
            {
                switch (islem)
                {
                    case Islemler.Yeni:
                        fnTemizle();
                        break;
                    case Islemler.Kaydet:
                        fnKaydet();
                        break;
                    case Islemler.Sil:
                        fnTemizle();
                        break;
                    case Islemler.Kapat:
                        Close();
                        break;
                    default:
                        break;
                    
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void fnBilgileriGetir()
        {
            fnKategoriler();
        }

        private void fnKategoriler()
        {
            gleKategori.Properties.DataSource = servis.SelectTable(clsGenel.Baglanti, "Select rid,kategori_kodu,kategori From Kategoriler where is_deleted=1 ");
        }
       private bool fnKaydet()
         {
             bool IsAdded = false;
             try
             {
                 int sonuc = 0;
                 String[] files = openFileDialog1.FileNames;
                 foreach (string dosya in txtresim.Text.Split(';'))
                 {
                     if (String.IsNullOrWhiteSpace(dosya))
                         continue;
                     byte[] resim = null;
                     string dosya_adi = String.Empty;
                     string dosya_yolu = String.Empty;

                     Dictionary<string, object> parametre = new Dictionary<string, object>();
                     Dictionary<string, object> paramKategori = new Dictionary<string, object>();

                     FileStream fs = new FileStream(dosya, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                     int uzunluk = Convert.ToInt32(fs.Length);
                     byte[] content = new byte[uzunluk];
                     fs.Read(content, 0, uzunluk);
                     fs.Flush();
                     fs.Close();

                     MemoryStream stream = new MemoryStream(content, true);
                     Image img = Image.FromStream(stream, true);
                     Bitmap bm = new Bitmap(img);
                     stream = new MemoryStream();
                     bm.Save(stream, ImageFormat.Gif);
                     resim = stream.ToArray();

                     FileInfo fi = new FileInfo(dosya);
                     dosya_adi = fi.Name;
                     dosya_yolu = fi.FullName;

                     parametre.Add("@resim_adi", dosya_adi);
                     parametre.Add("@resim_yolu", dosya_yolu);


                     parametre.Add("@kategori_rid", int.Parse(gleKategori.EditValue.ToString()));
                     parametre.Add("@resim", resim);
                     parametre.Add("@is_deleted", checkEdit1.Checked);
                     parametre.Add("@rid", rid);

                     string query = @"insert into Resimler(resim_adi,resim_yolu,resim,kategori_rid,is_deleted) values
                                 (@resim_adi,@resim_yolu,@resim,@kategori_rid,@is_deleted)
                                     SELECT SCOPE_IDENTITY() AS [SCOPE_IDENTITY]";
                     sonuc = servis.Insert(clsGenel.Baglanti, query, parametre);
                     if (sonuc > 0)
                     {
                         IsAdded = true;
                         IsDirty = true;
                         XtraMessageBox.Show("Kayıt Eklendi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                     }

                 }

             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }

             return IsAdded;
         } 

       

        private void fnTemizle()
        {
           txtresim.Text = gleKategori.Text = string.Empty;
            checkEdit1.Checked = true;
            rid = 0;
            pictureBox1.Image = null;
            pictureBox1.Invalidate();
        }

   

        private void simpleButton2_Click(object sender, EventArgs e)
        {


            txtresim.Text = String.Empty;
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "Resim Dosyaları (*.jpg, *.jpeg, *.bmp , *.emf , *.exif , *.gif , *.icon , *.png , *.tiff , *.wmf) | *.jpg; *.jpeg; *.bmp; *.emf; *.exif; *.gif; *.icon; *.png; *.tiff; *.wmf";
            openFileDialog1.Title = "Lütfen Resim Seçiniz";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                foreach (string img in openFileDialog1.FileNames)
                {
                    txtresim.Text += String.IsNullOrWhiteSpace(txtresim.Text) ? img : ";" + img;
                }
            }

        }

        private void fnYetkiler()
        {
            btnkaydet.Enabled = btnyenikaydet.Enabled = true;
            foreach (DataRow item in clsGenel.yetkiler.Rows)
            {
                switch (item["yetki_adi"].ToString())
                {
                    case "Resim İşlemleri":
                        btnkaydet.Enabled =  bool.Parse(item["ekleme"].ToString());
                        btnyenikaydet.Enabled = bool.Parse(item["okuma"].ToString());
                        break;
                    default:
                        break;
                }
            }
        }

        private void gridLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gleKategori_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Caption)
            {
                case "Ekle":
                    KategoriEkle kategori = new KategoriEkle();
                    kategori.ShowDialog();
                    if (kategori.IsDirty)
                        fnKategoriler();
                    break;
                case "Yenile":
                    fnKategoriler();
                    break;
                default:
                    break;
            }
        }


 

        private void btnkaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fnIslemler(Islemler.Kaydet);
        }

        private void btnyenikaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fnIslemler(Islemler.KaydetYeni);
        }

        private void btnkapat_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fnIslemler(Islemler.Kapat);
        }
    }

    }
