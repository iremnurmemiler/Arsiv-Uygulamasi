
namespace Arsiv
{
    partial class KategoriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KategoriEkle));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.textKategoriAdi = new DevExpress.XtraEditors.TextEdit();
            this.textKategoriKodu = new DevExpress.XtraEditors.TextEdit();
            this.Aktif = new DevExpress.XtraEditors.CheckEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barButtonKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonguncelle = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonTemizle = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dxHata = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.btnkapat = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textKategoriAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textKategoriKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aktif.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxHata)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textKategoriAdi);
            this.layoutControl1.Controls.Add(this.textKategoriKodu);
            this.layoutControl1.Controls.Add(this.Aktif);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(548, 148);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // textKategoriAdi
            // 
            this.textKategoriAdi.Location = new System.Drawing.Point(86, 36);
            this.textKategoriAdi.Name = "textKategoriAdi";
            this.textKategoriAdi.Size = new System.Drawing.Size(450, 20);
            this.textKategoriAdi.StyleController = this.layoutControl1;
            this.textKategoriAdi.TabIndex = 5;
            // 
            // textKategoriKodu
            // 
            this.textKategoriKodu.Location = new System.Drawing.Point(86, 12);
            this.textKategoriKodu.Name = "textKategoriKodu";
            this.textKategoriKodu.Size = new System.Drawing.Size(450, 20);
            this.textKategoriKodu.StyleController = this.layoutControl1;
            this.textKategoriKodu.TabIndex = 4;
            // 
            // Aktif
            // 
            this.Aktif.EditValue = true;
            this.Aktif.Location = new System.Drawing.Point(86, 60);
            this.Aktif.Name = "Aktif";
            this.Aktif.Properties.Caption = "";
            this.Aktif.Size = new System.Drawing.Size(450, 20);
            this.Aktif.StyleController = this.layoutControl1;
            this.Aktif.TabIndex = 9;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(548, 148);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textKategoriKodu;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(528, 24);
            this.layoutControlItem1.Text = "Kategori Kodu:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(71, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 72);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(528, 56);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textKategoriAdi;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(528, 24);
            this.layoutControlItem2.Text = "Kategori Adı:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(71, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.Aktif;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "Aktif:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(528, 24);
            this.layoutControlItem3.Text = "Aktif:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(71, 13);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonKaydet,
            this.barButtonTemizle,
            this.barButtonItem3,
            this.barButtonguncelle,
            this.btnkapat});
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonKaydet, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonguncelle, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonTemizle, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnkapat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barButtonKaydet
            // 
            this.barButtonKaydet.Caption = "KAYDET";
            this.barButtonKaydet.Id = 0;
            this.barButtonKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonKaydet.ImageOptions.Image")));
            this.barButtonKaydet.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonKaydet.ImageOptions.LargeImage")));
            this.barButtonKaydet.Name = "barButtonKaydet";
            this.barButtonKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonKaydet_ItemClick);
            // 
            // barButtonguncelle
            // 
            this.barButtonguncelle.Caption = "GÜNCELLE";
            this.barButtonguncelle.Id = 3;
            this.barButtonguncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonguncelle.ImageOptions.Image")));
            this.barButtonguncelle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonguncelle.ImageOptions.LargeImage")));
            this.barButtonguncelle.Name = "barButtonguncelle";
            // 
            // barButtonTemizle
            // 
            this.barButtonTemizle.Caption = "TEMİZLE";
            this.barButtonTemizle.Id = 1;
            this.barButtonTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonTemizle.ImageOptions.Image")));
            this.barButtonTemizle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonTemizle.ImageOptions.LargeImage")));
            this.barButtonTemizle.Name = "barButtonTemizle";
            this.barButtonTemizle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonTemizle_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = " ";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(548, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 148);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(548, 26);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 148);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(548, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 148);
            // 
            // dxHata
            // 
            this.dxHata.ContainerControl = this;
            // 
            // btnkapat
            // 
            this.btnkapat.Caption = "KAPAT";
            this.btnkapat.Id = 4;
            this.btnkapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkapat.ImageOptions.Image")));
            this.btnkapat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnkapat.ImageOptions.LargeImage")));
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnkapat_ItemClick);
            // 
            // KategoriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 174);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("KategoriEkle.IconOptions.LargeImage")));
            this.Name = "KategoriEkle";
            this.Text = "Kategori Ekleme";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textKategoriAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textKategoriKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aktif.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxHata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit textKategoriAdi;
        private DevExpress.XtraEditors.TextEdit textKategoriKodu;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem barButtonKaydet;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonTemizle;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraEditors.CheckEdit Aktif;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonguncelle;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxHata;
        private DevExpress.XtraBars.BarButtonItem btnkapat;
    }
}