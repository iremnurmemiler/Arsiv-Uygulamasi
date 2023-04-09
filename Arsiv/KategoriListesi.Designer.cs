
namespace Arsiv
{
    partial class KategoriListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KategoriListesi));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnyeni = new DevExpress.XtraBars.BarButtonItem();
            this.btndegistir = new DevExpress.XtraBars.BarButtonItem();
            this.btnsil = new DevExpress.XtraBars.BarButtonItem();
            this.btnyenile = new DevExpress.XtraBars.BarButtonItem();
            this.btnkapat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 24);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(670, 426);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsNavigation.AutoMoveRowFocus = false;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsNavigation.UseOfficePageNavigation = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnyeni,
            this.btndegistir,
            this.btnsil,
            this.btnyenile,
            this.btnkapat});
            this.barManager1.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(262, 81);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnyeni, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btndegistir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnsil, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnyenile, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnkapat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnyeni
            // 
            this.btnyeni.Caption = "Yeni";
            this.btnyeni.Id = 0;
            this.btnyeni.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnyeni.ImageOptions.Image")));
            this.btnyeni.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnyeni.ImageOptions.LargeImage")));
            this.btnyeni.Name = "btnyeni";
            this.btnyeni.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnyeni_ItemClick);
            // 
            // btndegistir
            // 
            this.btndegistir.Caption = "Değiştir";
            this.btndegistir.Id = 1;
            this.btndegistir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndegistir.ImageOptions.Image")));
            this.btndegistir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btndegistir.ImageOptions.LargeImage")));
            this.btndegistir.Name = "btndegistir";
            this.btndegistir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btndegistir_ItemClick);
            // 
            // btnsil
            // 
            this.btnsil.Caption = "Sil";
            this.btnsil.Id = 2;
            this.btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.ImageOptions.Image")));
            this.btnsil.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnsil.ImageOptions.LargeImage")));
            this.btnsil.Name = "btnsil";
            this.btnsil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnsil_ItemClick);
            // 
            // btnyenile
            // 
            this.btnyenile.Caption = "Yenile";
            this.btnyenile.Id = 3;
            this.btnyenile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnyenile.ImageOptions.Image")));
            this.btnyenile.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnyenile.ImageOptions.LargeImage")));
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnyenile_ItemClick);
            // 
            // btnkapat
            // 
            this.btnkapat.Caption = "Kapat";
            this.btnkapat.Id = 4;
            this.btnkapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkapat.ImageOptions.Image")));
            this.btnkapat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnkapat.ImageOptions.LargeImage")));
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnkapat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(670, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 450);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(670, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 426);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(670, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 426);
            // 
            // KategoriListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "KategoriListesi";
            this.Text = "Kategori Listesi";
            this.Load += new System.EventHandler(this.KategoriListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnyeni;
        private DevExpress.XtraBars.BarButtonItem btndegistir;
        private DevExpress.XtraBars.BarButtonItem btnsil;
        private DevExpress.XtraBars.BarButtonItem btnyenile;
        private DevExpress.XtraBars.BarButtonItem btnkapat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}