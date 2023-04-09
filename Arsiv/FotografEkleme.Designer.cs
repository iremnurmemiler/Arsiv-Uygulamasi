
namespace Arsiv
{
    partial class FotografEkleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FotografEkleme));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gleKategori = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtresim = new System.Windows.Forms.TextBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnkaydet = new DevExpress.XtraBars.BarButtonItem();
            this.btnyenikaydet = new DevExpress.XtraBars.BarButtonItem();
            this.btnkapat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleKategori.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.pictureBox1);
            this.layoutControl1.Controls.Add(this.gleKategori);
            this.layoutControl1.Controls.Add(this.txtresim);
            this.layoutControl1.Controls.Add(this.simpleButton2);
            this.layoutControl1.Controls.Add(this.checkEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 173, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(666, 408);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(94, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // gleKategori
            // 
            this.gleKategori.EditValue = "Kategori Seçiniz..";
            this.gleKategori.Location = new System.Drawing.Point(94, 38);
            this.gleKategori.Name = "gleKategori";
            this.gleKategori.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gleKategori.Properties.DisplayMember = "kategori_kodu";
            this.gleKategori.Properties.NullText = "Kategori Seçiniz..";
            this.gleKategori.Properties.PopupView = this.gridLookUpEdit2View;
            this.gleKategori.Properties.ValueMember = "rid";
            this.gleKategori.Size = new System.Drawing.Size(560, 20);
            this.gleKategori.StyleController = this.layoutControl1;
            this.gleKategori.TabIndex = 8;
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // txtresim
            // 
            this.txtresim.Location = new System.Drawing.Point(94, 12);
            this.txtresim.Name = "txtresim";
            this.txtresim.Size = new System.Drawing.Size(531, 20);
            this.txtresim.TabIndex = 5;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(629, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(25, 22);
            this.simpleButton2.StyleController = this.layoutControl1;
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "...";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // checkEdit1
            // 
            this.checkEdit1.EditValue = true;
            this.checkEdit1.Location = new System.Drawing.Point(94, 62);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "";
            this.checkEdit1.Size = new System.Drawing.Size(560, 20);
            this.checkEdit1.StyleController = this.layoutControl1;
            this.checkEdit1.TabIndex = 9;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.simpleSeparator1,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(666, 408);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtresim;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(617, 26);
            this.layoutControlItem2.Text = "Resim Seçiniz:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.simpleButton2;
            this.layoutControlItem4.Location = new System.Drawing.Point(617, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(29, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gleKategori;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(646, 24);
            this.layoutControlItem3.Text = "Kategori:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.checkEdit1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(646, 24);
            this.layoutControlItem5.Text = "Aktif:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(79, 13);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 74);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(646, 1);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.pictureBox1;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 75);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(646, 313);
            this.layoutControlItem6.Text = "Seçilen Görüntü:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(79, 13);
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
            this.btnkaydet,
            this.btnyenikaydet,
            this.btnkapat});
            this.barManager1.MaxItemId = 3;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnkaydet, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnyenikaydet, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnkapat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // btnkaydet
            // 
            this.btnkaydet.Caption = "Kaydet";
            this.btnkaydet.Id = 0;
            this.btnkaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.ImageOptions.Image")));
            this.btnkaydet.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnkaydet.ImageOptions.LargeImage")));
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnkaydet_ItemClick);
            // 
            // btnyenikaydet
            // 
            this.btnyenikaydet.Caption = "Yeni Kaydet";
            this.btnyenikaydet.Id = 1;
            this.btnyenikaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnyenikaydet.ImageOptions.Image")));
            this.btnyenikaydet.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnyenikaydet.ImageOptions.LargeImage")));
            this.btnyenikaydet.Name = "btnyenikaydet";
            // 
            // btnkapat
            // 
            this.btnkapat.Caption = "Kapat";
            this.btnkapat.Id = 2;
            this.btnkapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkapat.ImageOptions.Image")));
            this.btnkapat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnkapat.ImageOptions.LargeImage")));
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnkapat_ItemClick_1);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(666, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 408);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(666, 26);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 408);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(666, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 408);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FotografEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 434);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FotografEkleme.IconOptions.LargeImage")));
            this.Name = "FotografEkleme";
            this.Text = "Fotoğraf Ekleme";
            this.Load += new System.EventHandler(this.FotografEkleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleKategori.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.GridLookUpEdit gleKategori;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private System.Windows.Forms.TextBox txtresim;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnkaydet;
        private DevExpress.XtraBars.BarButtonItem btnyenikaydet;
        private DevExpress.XtraBars.BarButtonItem btnkapat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        
    }
}