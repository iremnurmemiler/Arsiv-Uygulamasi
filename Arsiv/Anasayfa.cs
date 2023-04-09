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
    public partial class Anasayfa : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Anasayfa()
        {
            InitializeComponent();
        }


        private void fnyetkiler()
        {
            btnfotoekle.Enabled = false;
            btnfotolistele.Enabled = false;
            btnktgekle.Enabled = false;
            btnktglistesi.Enabled = false;
            btnyetki.Enabled = false;

            foreach (DataRow item in clsGenel.yetkiler.Rows)
            {
                switch (item["yetki_adi"].ToString())
                {
                    case "Kategori İşlemleri":
                        btnktglistesi.Enabled = bool.Parse(item["okuma"].ToString());
                        btnktgekle.Enabled = bool.Parse(item["ekleme"].ToString());
                        break;
                    case "Resim İşlemleri":
                        btnfotolistele.Enabled = bool.Parse(item["okuma"].ToString());
                        btnfotoekle.Enabled = bool.Parse(item["ekleme"].ToString());
                        break;

                    case "Kullanıcı Yetkilendirme İşlemleri":
                        btnyetki.Enabled = bool.Parse(item["ekleme"].ToString());
                        break; 
                    default:
                        break;
                        
                }
            }
        }

        private void Acilacak_Sayfa(Form Acilacak)
        {
            bool durum = false;
            foreach (Form eleman in this.MdiChildren)
            {
                if (eleman.Name == Acilacak.Name)
                {
                    durum = true;
                    eleman.Activate();
                }
            }
                if (!durum)
                {
                    Acilacak.MdiParent = this;
                    Acilacak.Show();
                }
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FotografEkleme fotoekle = new FotografEkleme();
            Acilacak_Sayfa(fotoekle);
        }

        private void btnfotolistele_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FotografListeleme fotolistele = new FotografListeleme();
            Acilacak_Sayfa(fotolistele);
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KategoriEkle ke = new KategoriEkle();
            Acilacak_Sayfa(ke);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/iremnurmemiler/C--ile-fotograf-arsivleme");
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KategoriListesi kl = new KategoriListesi();
            Acilacak_Sayfa(kl);
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void Anasayfa_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control && e.Shift && e.KeyCode == Keys.D)
                {
                    DbConfig.frmDbBaglanti db = new DbConfig.frmDbBaglanti();
                    db.ShowDialog();
                }
            }
            catch
            {
            }
        }

        private void btnyetki_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmYetkiEkleme frmYetki = new frmYetkiEkleme();
            Acilacak_Sayfa(frmYetki);
        }
    }
}
