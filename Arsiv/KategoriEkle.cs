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
    public partial class KategoriEkle : DevExpress.XtraEditors.XtraForm
    {
        public KategoriEkle()
        {
            InitializeComponent();
        }
        public KategoriEkle(int _rid)
        {
            InitializeComponent();
            rid = _rid;
        }
        private void frmKategoriEkleme_Load(object sender, EventArgs e)
        {
            fnYetkiler();
            fnBilgileriGetir();
        }

        private void fnYetkiler()
        {
            barButtonKaydet.Enabled = barButtonTemizle.Enabled = false;
            foreach (DataRow item in clsGenel.yetkiler.Rows)
            {
                switch (item["yetki_adi"].ToString())
                {
                    case "Kategori İşlemleri":
                        barButtonKaydet.Enabled = barButtonTemizle.Enabled = barButtonguncelle.Enabled = bool.Parse(item["ekleme"].ToString());
                        barButtonguncelle.Enabled = bool.Parse(item["okuma"].ToString());
                        break;
                    default:
                        break;
                }
            }
        }

        int rid = 0;
        public bool IsDirty = false;
        Sql_Servis servis = new Sql_Servis();

        private void fnIslemler(Islemler islem)
        {
            try
            {
                switch (islem)
                {
                   
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
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fnBilgileriGetir()
        {
            if (rid > 0)
            {
                try
                {
                    Dictionary<string, object> p = new Dictionary<string, object>();
                    p.Add("@rid", rid);
                    DataTable sonuc = servis.SelectTable(clsGenel.Baglanti, "Select * from Kategoriler where rid=@rid", p);
                    if (sonuc.Rows.Count > 0)
                    {
                        textKategoriKodu.Text = sonuc.Rows[0]["kategori_kodu"].ToString();
                        textKategoriAdi.Text = sonuc.Rows[0]["kategori"].ToString();
                        Aktif.Checked = bool.Parse(sonuc.Rows[0]["is_deleted"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
      private void fnHataKontrol()
        {
            dxHata.ClearErrors();
            if (String.IsNullOrWhiteSpace(textKategoriAdi.Text))
            {
                dxHata.SetError(textKategoriAdi, "Kategori Adını Giriniz!");
            }
            if (String.IsNullOrWhiteSpace(textKategoriKodu.Text))
            {
                dxHata.SetError(textKategoriKodu, "Kategori Kodunu Giriniz!");
            }
        }

        private bool fnKaydet()
        {
            bool IsAdded = false;
            try
            {
                fnHataKontrol();
                if (dxHata.HasErrors)
                  return false;
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("@kategori_kodu", textKategoriKodu.Text);
                param.Add("@kategori_adi", textKategoriAdi.Text);
                param.Add("@is_deleted", Aktif.Checked);
                param.Add("@rid", rid);

                string query = @"insert into Kategoriler(kategori_kodu,kategori,is_deleted)
                             Values (@kategori_kodu,@kategori_adi,@is_deleted)
                             SELECT SCOPE_IDENTITY() AS [SCOPE_IDENTITY] ";
                string mesaj = "Kayıt Eklendi!";
                this.Close();
                if (rid > 0)
                {
                    query = @"Update Kategoriler Set kategori_kodu=@kategori_kodu,kategori=@kategori_adi,
                           is_deleted=@is_deleted where rid=@rid select @rid ";
                    mesaj = "Kayıt Güncellendi!";
                }
                int sonuc = servis.Insert(clsGenel.Baglanti, query, param);
                if (sonuc > 0)
                {
                    rid = sonuc;
                    IsDirty = true;
                    IsAdded = true;
                    XtraMessageBox.Show(mesaj, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return IsAdded;
        }
        private void fnTemizle()
        {
            rid = 0;
            textKategoriAdi.Text = textKategoriKodu.Text = String.Empty;
            Aktif.Checked = true;
        }
        private void barButtonKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fnIslemler(Islemler.Kaydet);
        }

        private void barButtonTemizle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fnIslemler(Islemler.Sil);
        }

        private void btnkapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fnIslemler(Islemler.Kapat);
        }
    }
}
