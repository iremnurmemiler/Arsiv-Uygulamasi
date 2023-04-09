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
    public partial class KategoriListesi : DevExpress.XtraEditors.XtraForm
    {
        public KategoriListesi()
        {
            InitializeComponent();
        }
        Sql_Servis servis;
        private void KategoriListesi_Load(object sender, EventArgs e)
        {
            fnYetkiler();
            servis = new Sql_Servis();
            fnIslemler(ListeIslemleri.Yenile);
        }


        private void fnYetkiler()
        {
            btnyeni.Enabled = btndegistir.Enabled = btnsil.Enabled = btnyenile.Enabled =  false;
            foreach (DataRow item in clsGenel.yetkiler.Rows)
            {
                switch (item["yetki_adi"].ToString())
                {
                    case "Kategori İşlemleri":
                        btnyeni.Enabled = bool.Parse(item["okuma"].ToString());
                        btndegistir.Enabled = bool.Parse(item["guncelleme"].ToString());
                        btnsil.Enabled = bool.Parse(item["silme"].ToString());
                        btnyenile.Enabled = bool.Parse(item["okuma"].ToString());
                     
                        break;
                    default:
                        break;
                }
            }
        }
        private void fnIslemler(ListeIslemleri islem)
        {
            try
            {
                switch (islem)
                {
                    case ListeIslemleri.Yeni:
                       KategoriEkle kategori = new KategoriEkle();
                        kategori.ShowDialog(); 
                        break;
                    case ListeIslemleri.Degistir:
                        if (gridView1.FocusedRowHandle >= 0)
                        {
                            DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                            int _rid = int.Parse(row["rid"].ToString());
                            KategoriEkle guncelle = new KategoriEkle(_rid);
                            guncelle.ShowDialog();
                            if (guncelle.IsDirty)
                                fnIslemler(ListeIslemleri.Yenile);

                        }
                        break;
                    case ListeIslemleri.Sil:
                        if (DialogResult.No == XtraMessageBox.Show("Seçili kaydı SİLMEK istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                            return;
                        DataRow rowDelete = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                        int idDelete = int.Parse(rowDelete["rid"].ToString());
                        string query = @"Delete from Kategoriler Where rid=@rid";
                        Dictionary<string, object> param = new Dictionary<string, object>();
                        param.Add("@rid", idDelete);
                        bool sonuc = servis.Delete(clsGenel.Baglanti, query, param);
                        if (sonuc)
                            fnIslemler(ListeIslemleri.Yenile);
                        break;
                    case ListeIslemleri.Yenile:
                        gridControl1.DataSource = servis.SelectTable(clsGenel.Baglanti, "Select * from Kategoriler");
                        break;
                    case ListeIslemleri.Kapat:
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

       

        private void btnyeni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fnIslemler(ListeIslemleri.Yeni);
           
        }

        private void btndegistir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fnIslemler(ListeIslemleri.Degistir);
        }

        private void btnsil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fnIslemler(ListeIslemleri.Sil);
        }

        private void btnyenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fnIslemler(ListeIslemleri.Yenile);
        }

        private void btnkapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fnIslemler(ListeIslemleri.Kapat);
        }
    }
}
