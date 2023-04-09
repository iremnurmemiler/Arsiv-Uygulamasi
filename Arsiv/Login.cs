using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arsiv
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Sql_Servis servis = new Sql_Servis();
        public bool IsLogged = false;
        private Point MouseDownPosition;

        private void fnHataKontrol()
        {
            dxHata.ClearErrors();
            if (String.IsNullOrWhiteSpace(txtkadi.Text))
            {
                dxHata.SetError(txtkadi, "Kullanıcı Adı Giriniz!");
            }
            if (String.IsNullOrWhiteSpace(txtsifre.Text))
            {
                dxHata.SetError(txtsifre, "Şifrenizi Giriniz!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            fnHataKontrol();
            if (dxHata.HasErrors)
            {
                XtraMessageBox.Show("Bilgilerinizi Kontrol Ediniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
         

            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@kullanici_adi", txtkadi.Text);
            param.Add("@sifre", txtsifre.Text);
            string query = @"Select * from Kullanicilar where kullanici_adi=@kullanici_adi and sifre=@sifre and is_deleted=1 ";
            object sonuc = servis.SelectScalar(clsGenel.Baglanti, query, param);
            if (sonuc != null)
            {
                Dictionary<string, object> p = new Dictionary<string, object>();
                 p.Add("@kullanici_adi", txtkadi.Text);
                 string queryYetki = @"select ky.rid,ky.kullanici_rid,ky.yetki_rid,ky.ekleme,ky.silme,ky.guncelleme,ky.okuma,y.yetki_adi 
                                          from Kullanici_Yetkiler ky(nolock),Yetkiler y(nolock) 
                                          where ky.yetki_rid=y.rid and  kullanici_rid=(select rid from Kullanicilar where kullanici_adi=@kullanici_adi and is_deleted=1 )";
                 clsGenel.yetkiler = servis.SelectTable(clsGenel.Baglanti, queryYetki, p);
                 IsLogged = true;
                 Close();

            }
            else
            {
                XtraMessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtkadi.Text = String.Empty;
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtkadi.Focus();
        }

        private void Login_MouseLeave(object sender, EventArgs e)
        {
            simpleButton1.ForeColor = Color.Black;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDownPosition = e.Location;
            }
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    this.Left = e.X + this.Left - MouseDownPosition.X;
                    this.Top = e.Y + this.Top - MouseDownPosition.Y;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
