using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Arsiv
{
    public partial class frmYetkiEkleme : DevExpress.XtraEditors.XtraForm
    {
        public frmYetkiEkleme()
        {
            InitializeComponent();
        }
        int rid = 0;
        Sql_Servis servis = new Sql_Servis();
        DataTable dtYetkiler = new DataTable();
        private void frmYetkiEkleme_Load(object sender, EventArgs e)
        {
            fnYetkiler();
            fnBilgileriGetir();
        }

        private void fnYetkiler()
        {
            btnKaydet.Enabled = false;
            foreach (DataRow item in clsGenel.yetkiler.Rows)
            {
                switch (item["yetki_adi"].ToString())
                {
                    case "Kullanıcı Yetkilendirme İşlemleri":
                        btnKaydet.Enabled = bool.Parse(item["ekleme"].ToString());                       
                        break;
                    default:
                        break;
                }
            }
        }

        private void fnBilgileriGetir()
        {
            fnKullanicilar();
        }
        private void fnKullanicilar()
        {
            gleKullanici.Properties.DataSource = servis.SelectTable(clsGenel.Baglanti, "Select rid,kullanici_adi from Kullanicilar");
        }
        private void fnIslemler(ListeIslemleri islem)
        {
            try
            {
                switch (islem)
                {
                    case ListeIslemleri.Yenile:
                        
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
        private void fnKaydet()
        {
            int kullanici_rid = int.Parse(gleKullanici.EditValue.ToString());
            try
            {
                string query = @"if @rid=0
                          begin
                           insert into Kullanici_Yetkiler(kullanici_rid,yetki_rid,ekleme,silme,guncelleme,okuma)
                           values(@kullanici_rid,@yetki_rid,@ekleme,@silme,@guncelleme,@okuma)
                           SELECT SCOPE_IDENTITY() AS [SCOPE_IDENTITY]
                          end
                         else
                          begin
                           update Kullanici_Yetkiler set kullanici_rid=@kullanici_rid,yetki_rid=@yetki_rid,ekleme=@ekleme,silme=@silme,
                                  guncelleme=@guncelleme,okuma=@okuma
                           where kullanici_rid=@kullanici_rid and yetki_rid=@yetki_rid 
                              select @rid    
                                end";

                Dictionary<string, object> p;
                if (gridView1.FocusedRowHandle == gridView1.RowCount)
                    gridView1.FocusedRowHandle = 0;
                gridView1.FocusedRowHandle = gridView1.FocusedRowHandle + 1;
                gridView1.FocusedRowHandle = gridView1.FocusedRowHandle - 1;
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    DataRow row = gridView1.GetDataRow(i);
                    p = new Dictionary<string, object>(); 
                    p.Add("@rid", int.Parse(row["rid"].ToString()));
                    p.Add("@kullanici_rid", kullanici_rid);
                    p.Add("@okuma", bool.Parse(row["okuma"].ToString()));
                   
                    p.Add("@guncelleme", bool.Parse(row["guncelleme"].ToString()));
                    p.Add("@silme", bool.Parse(row["silme"].ToString()));
                
                    p.Add("@yetki_rid", int.Parse(row["yetki_rid"].ToString()));
                    p.Add("@ekleme", bool.Parse(row["ekleme"].ToString()));
                    servis.Update(clsGenel.Baglanti, query, p);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            XtraMessageBox.Show("Kayıt Eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
        private void btnKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fnKaydet();
        }
        private void gleKullanici_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if(gleKullanici.EditValue==null)
                {
                    XtraMessageBox.Show("Kullanıcı Seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int kullanici_rid = int.Parse(gleKullanici.EditValue.ToString());
                Dictionary<string, object> p = new Dictionary<string, object>();
                 p.Add("@kullanici_rid", kullanici_rid);
                string query = @"select ky.rid,ky.yetki_rid,ky.kullanici_rid,ky.ekleme,ky.guncelleme,ky.okuma,ky.silme,y.yetki_adi 
                                from Kullanici_Yetkiler ky,Yetkiler y
                                where ky.yetki_rid=y.rid and ky.kullanici_rid=@kullanici_rid
                                union
                                ---ustteki sorguda olanlar hariç varsayılan yetkiler false olacak sekilde getir
                                select 0 rid,y.rid yetki_rid,@kullanici_rid kullanici_rid,
	                                   CONVERT(bit,0) ekleme,CONVERT(bit,0) guncelleme,CONVERT(bit,0) okuma,CONVERT(bit,0) silme,y.yetki_adi 	
                                from Yetkiler y
                                where y.rid not in (select yetki_rid from Kullanici_Yetkiler where kullanici_rid=@kullanici_rid)
                                    "; 
                dtYetkiler = servis.SelectTable(clsGenel.Baglanti,query , p );
                
                foreach (DataColumn item in dtYetkiler.Columns)
                {
                    item.ReadOnly = false; 
                }
                gridControl1.DataSource = dtYetkiler;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bbiKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}