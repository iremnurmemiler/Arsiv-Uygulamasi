using DevExpress.XtraEditors;
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

namespace Arsiv
{
    public partial class FotografListeleme : DevExpress.XtraEditors.XtraForm
    {
        public FotografListeleme()
        {
            InitializeComponent();
        }
        Sql_Servis servis = new Sql_Servis();
        private void FotografListeleme_Load(object sender, EventArgs e)
        {
            fnYetkiler();
            fnIslemler(ListeIslemleri.Yenile);
        }
        private void fnYetkiler()
        {
            btnyeni.Enabled = btnsil.Enabled = false;
            foreach (DataRow item in clsGenel.yetkiler.Rows)
            {
                switch (item["yetki_adi"].ToString())
                {
                    case "Resim İşlemleri":
                        btnyeni.Enabled = bool.Parse(item["okuma"].ToString());
                        btnyenile.Enabled = bool.Parse(item["okuma"].ToString());
                        btnsil.Enabled = bool.Parse(item["silme"].ToString());
                       
                    
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
                        FotografEkleme resim = new FotografEkleme();
                        resim.ShowDialog();
                        break;
                    case ListeIslemleri.Yenile:
                        gridControl1.DataSource = servis.SelectTable(clsGenel.Baglanti, "Select * from Resimler");
                        break;
          
                        break;
                    case ListeIslemleri.Sil:
                        if (DialogResult.No == XtraMessageBox.Show("Seçili kayıtı Silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                            return;
                        DataRow rowDelete = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                        int idDelete = int.Parse(rowDelete["rid"].ToString());
                        string query = @"Delete from Resimler Where rid=@rid";
                        Dictionary<string, object> param = new Dictionary<string, object>();
                        param.Add("@rid", idDelete);
                        bool sonuc = servis.Delete(clsGenel.Baglanti, query, param);
                        if (sonuc)
                            fnIslemler(ListeIslemleri.Yenile);
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

     private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
       {
            if (gridView1.FocusedRowHandle >= 0)
           {
               string query = @"Select Top 1 resim from Resimler (nolock)  Where rid=@rid order by rid desc";
               Dictionary<string, object> p = new Dictionary<string, object>();
               DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
               int id = int.Parse(row["rid"].ToString());
               p.Add("@rid", id);
               object sonuc = servis.SelectScalar(clsGenel.Baglanti, query, p);
               if (sonuc != null)
               {
                   byte[] resimbyte = (byte[])sonuc;
                   MemoryStream stream = new MemoryStream(resimbyte);
                   pbresim.Image = Image.FromStream(stream);
               }
           }
           else
               pbresim.Image = null;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fnIslemler(ListeIslemleri.Kapat);
        }

        private void btnsil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fnIslemler(ListeIslemleri.Sil);
        }

      

        private void btnyenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fnIslemler(ListeIslemleri.Yenile);
        }
    }
}
