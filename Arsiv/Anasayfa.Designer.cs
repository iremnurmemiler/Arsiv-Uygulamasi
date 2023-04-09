
namespace Arsiv
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnfotoekle = new DevExpress.XtraBars.BarButtonItem();
            this.btnfotolistele = new DevExpress.XtraBars.BarButtonItem();
            this.btnktgekle = new DevExpress.XtraBars.BarButtonItem();
            this.btnyetki = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnktglistesi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnfotoekle,
            this.btnfotolistele,
            this.btnktgekle,
            this.btnyetki,
            this.barButtonItem3,
            this.btnktglistesi,
            this.barButtonItem5,
            this.barButtonItem6});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.QuickToolbarItemLinks.Add(this.barButtonItem3);
            this.ribbonControl1.Size = new System.Drawing.Size(689, 177);
            // 
            // btnfotoekle
            // 
            this.btnfotoekle.Caption = "Fotoğraf Ekle";
            this.btnfotoekle.Id = 1;
            this.btnfotoekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnfotoekle.ImageOptions.Image")));
            this.btnfotoekle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnfotoekle.ImageOptions.LargeImage")));
            this.btnfotoekle.Name = "btnfotoekle";
            this.btnfotoekle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnfotolistele
            // 
            this.btnfotolistele.Caption = "Fotoğraf Listele";
            this.btnfotolistele.Id = 3;
            this.btnfotolistele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnfotolistele.ImageOptions.Image")));
            this.btnfotolistele.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnfotolistele.ImageOptions.LargeImage")));
            this.btnfotolistele.Name = "btnfotolistele";
            this.btnfotolistele.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnfotolistele_ItemClick);
            // 
            // btnktgekle
            // 
            this.btnktgekle.Caption = "Kategori Ekle";
            this.btnktgekle.Id = 4;
            this.btnktgekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnktgekle.ImageOptions.Image")));
            this.btnktgekle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnktgekle.ImageOptions.LargeImage")));
            this.btnktgekle.Name = "btnktgekle";
            this.btnktgekle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick_1);
            // 
            // btnyetki
            // 
            this.btnyetki.Caption = "Yetkilendirme";
            this.btnyetki.Id = 5;
            this.btnyetki.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnyetki.ImageOptions.Image")));
            this.btnyetki.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnyetki.ImageOptions.LargeImage")));
            this.btnyetki.Name = "btnyetki";
            this.btnyetki.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnyetki_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "btnhakkinda";
            this.barButtonItem3.Id = 6;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // btnktglistesi
            // 
            this.btnktglistesi.Caption = "Kategori Listesi";
            this.btnktglistesi.Id = 7;
            this.btnktglistesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnktglistesi.ImageOptions.Image")));
            this.btnktglistesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnktglistesi.ImageOptions.LargeImage")));
            this.btnktglistesi.Name = "btnktglistesi";
            this.btnktglistesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Kullanıcı Ekle";
            this.barButtonItem5.Id = 8;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Kullanıcı Listele";
            this.barButtonItem6.Id = 9;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.ImageOptions.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "İşlemler";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnfotoekle);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnfotolistele, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Fotoğraf İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnktgekle, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnktglistesi);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Kategori İşlemleri";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnyetki);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Yetkili İşlemleri";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 500);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Anasayfa.IconOptions.Image")));
            this.IsMdiContainer = true;
            this.Name = "Anasayfa";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Anasayfa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnfotoekle;
        private DevExpress.XtraBars.BarButtonItem btnfotolistele;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnktgekle;
        private DevExpress.XtraBars.BarButtonItem btnyetki;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnktglistesi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}