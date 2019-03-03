namespace HTManagement.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonMenu = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.backstageMenu = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.PrintTab = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.ExportTab = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.Print = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.backstageViewItemSeparator1 = new DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator();
            this.backstageViewTabItem3 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.backstageViewItemSeparator2 = new DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator();
            this.btnProducts = new DevExpress.XtraBars.BarButtonItem();
            this.btnUnit = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditInfo = new DevExpress.XtraBars.BarButtonItem();
            this.btnInfo = new DevExpress.XtraBars.BarButtonItem();
            this.btnHome = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonSetting = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonHelp = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.backstageViewClientControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.backstageViewTabItem1 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.tabMain = new DevExpress.XtraTab.XtraTabControl();
            this.homeControl = new DevExpress.XtraTab.XtraTabPage();
            this.backstageViewControl2 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.backstageViewClientControl2 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.backstageViewTabItem2 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.printContent = new DevExpress.XtraBars.Ribbon.RecentItemControl();
            this.recentStackPanel1 = new DevExpress.XtraBars.Ribbon.RecentStackPanel();
            this.recentStackPanel2 = new DevExpress.XtraBars.Ribbon.RecentStackPanel();
            this.btnPdf = new DevExpress.XtraBars.Ribbon.RecentButtonItem();
            this.exportContent = new DevExpress.XtraBars.Ribbon.RecentItemControl();
            this.recentStackPanel3 = new DevExpress.XtraBars.Ribbon.RecentStackPanel();
            this.recentStackPanel4 = new DevExpress.XtraBars.Ribbon.RecentStackPanel();
            this.recentStackPanel5 = new DevExpress.XtraBars.Ribbon.RecentStackPanel();
            this.recentTabItem1 = new DevExpress.XtraBars.Ribbon.RecentTabItem();
            this.recentButtonItem1 = new DevExpress.XtraBars.Ribbon.RecentButtonItem();
            this.recentButtonItem2 = new DevExpress.XtraBars.Ribbon.RecentButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageMenu)).BeginInit();
            this.backstageMenu.SuspendLayout();
            this.PrintTab.SuspendLayout();
            this.ExportTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).BeginInit();
            this.backstageViewControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.homeControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl2)).BeginInit();
            this.backstageViewControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportContent)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonMenu
            // 
            this.ribbonMenu.ApplicationButtonDropDownControl = this.backstageMenu;
            this.ribbonMenu.ExpandCollapseItem.Id = 0;
            this.ribbonMenu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonMenu.ExpandCollapseItem,
            this.btnProducts,
            this.btnUnit,
            this.btnEditInfo,
            this.btnInfo,
            this.btnHome,
            this.barStaticItem1});
            this.ribbonMenu.Location = new System.Drawing.Point(0, 0);
            this.ribbonMenu.MaxItemId = 7;
            this.ribbonMenu.Name = "ribbonMenu";
            this.ribbonMenu.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonSetting,
            this.ribbonHelp});
            this.ribbonMenu.Size = new System.Drawing.Size(1132, 143);
            this.ribbonMenu.StatusBar = this.ribbonStatusBar;
            // 
            // backstageMenu
            // 
            this.backstageMenu.Controls.Add(this.PrintTab);
            this.backstageMenu.Controls.Add(this.ExportTab);
            this.backstageMenu.Items.Add(this.Print);
            this.backstageMenu.Items.Add(this.backstageViewItemSeparator1);
            this.backstageMenu.Items.Add(this.backstageViewTabItem3);
            this.backstageMenu.Items.Add(this.backstageViewItemSeparator2);
            this.backstageMenu.Location = new System.Drawing.Point(-1, 27);
            this.backstageMenu.Name = "backstageMenu";
            this.backstageMenu.OwnerControl = this.ribbonMenu;
            this.backstageMenu.SelectedTab = this.Print;
            this.backstageMenu.SelectedTabIndex = 0;
            this.backstageMenu.Size = new System.Drawing.Size(1123, 454);
            this.backstageMenu.Style = DevExpress.XtraBars.Ribbon.BackstageViewStyle.Office2013;
            this.backstageMenu.TabIndex = 0;
            this.backstageMenu.Text = "File Control";
            // 
            // PrintTab
            // 
            this.PrintTab.Controls.Add(this.printContent);
            this.PrintTab.Location = new System.Drawing.Point(132, 63);
            this.PrintTab.Name = "PrintTab";
            this.PrintTab.Size = new System.Drawing.Size(990, 390);
            this.PrintTab.TabIndex = 1;
            // 
            // ExportTab
            // 
            this.ExportTab.Controls.Add(this.exportContent);
            this.ExportTab.Location = new System.Drawing.Point(132, 63);
            this.ExportTab.Name = "ExportTab";
            this.ExportTab.Size = new System.Drawing.Size(990, 390);
            this.ExportTab.TabIndex = 2;
            // 
            // Print
            // 
            this.Print.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.Print.Caption = "In";
            this.Print.ContentControl = this.PrintTab;
            this.Print.ImageOptions.ItemNormal.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Print.ImageOptions.ItemNormal.SvgImage")));
            this.Print.Name = "Print";
            this.Print.Selected = true;
            // 
            // backstageViewItemSeparator1
            // 
            this.backstageViewItemSeparator1.Name = "backstageViewItemSeparator1";
            // 
            // backstageViewTabItem3
            // 
            this.backstageViewTabItem3.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.backstageViewTabItem3.Caption = "Export";
            this.backstageViewTabItem3.ContentControl = this.ExportTab;
            this.backstageViewTabItem3.ImageOptions.ItemNormal.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("backstageViewTabItem3.ImageOptions.ItemNormal.SvgImage")));
            this.backstageViewTabItem3.Name = "backstageViewTabItem3";
            // 
            // backstageViewItemSeparator2
            // 
            this.backstageViewItemSeparator2.Name = "backstageViewItemSeparator2";
            // 
            // btnProducts
            // 
            this.btnProducts.Caption = "Sản phẩm";
            this.btnProducts.Id = 1;
            this.btnProducts.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.ImageOptions.Image")));
            this.btnProducts.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnProducts.ImageOptions.LargeImage")));
            this.btnProducts.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnProducts.ImageOptions.SvgImage")));
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProducts_ItemClick);
            // 
            // btnUnit
            // 
            this.btnUnit.Caption = "Đơn vị";
            this.btnUnit.Id = 2;
            this.btnUnit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUnit.ImageOptions.Image")));
            this.btnUnit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUnit.ImageOptions.LargeImage")));
            this.btnUnit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUnit.ImageOptions.SvgImage")));
            this.btnUnit.Name = "btnUnit";
            this.btnUnit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUnit_ItemClick);
            // 
            // btnEditInfo
            // 
            this.btnEditInfo.Caption = "Thông tin cơ bản";
            this.btnEditInfo.Id = 3;
            this.btnEditInfo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditInfo.ImageOptions.Image")));
            this.btnEditInfo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEditInfo.ImageOptions.LargeImage")));
            this.btnEditInfo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEditInfo.ImageOptions.SvgImage")));
            this.btnEditInfo.Name = "btnEditInfo";
            this.btnEditInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditInfo_ItemClick);
            // 
            // btnInfo
            // 
            this.btnInfo.Caption = "Thông tin";
            this.btnInfo.Id = 4;
            this.btnInfo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInfo.ImageOptions.SvgImage")));
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInfo_ItemClick);
            // 
            // btnHome
            // 
            this.btnHome.Caption = "Trang chủ";
            this.btnHome.Id = 5;
            this.btnHome.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHome.ImageOptions.SvgImage")));
            this.btnHome.Name = "btnHome";
            this.btnHome.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHome_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem1.Caption = "Ứng dụng quản lý cân";
            this.barStaticItem1.Id = 6;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // ribbonSetting
            // 
            this.ribbonSetting.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonSetting.Name = "ribbonSetting";
            this.ribbonSetting.Text = "Cài đặt";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnProducts);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Sản phẩm";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnUnit);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Đơn vị";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnEditInfo);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Thông tin cơ bản";
            // 
            // ribbonHelp
            // 
            this.ribbonHelp.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonHelp.Name = "ribbonHelp";
            this.ribbonHelp.Text = "Trợ giúp";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnInfo);
            this.ribbonPageGroup4.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.TwoRows;
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Thông tin ứng dụng";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 655);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonMenu;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1132, 31);
            // 
            // backstageViewControl1
            // 
            this.backstageViewControl1.Controls.Add(this.backstageViewClientControl1);
            this.backstageViewControl1.Items.Add(this.backstageViewTabItem1);
            this.backstageViewControl1.Location = new System.Drawing.Point(71, 214);
            this.backstageViewControl1.Name = "backstageViewControl1";
            this.backstageViewControl1.Size = new System.Drawing.Size(480, 150);
            this.backstageViewControl1.TabIndex = 5;
            // 
            // backstageViewClientControl1
            // 
            this.backstageViewClientControl1.Location = new System.Drawing.Point(188, 0);
            this.backstageViewClientControl1.Name = "backstageViewClientControl1";
            this.backstageViewClientControl1.Size = new System.Drawing.Size(292, 150);
            this.backstageViewClientControl1.TabIndex = 1;
            // 
            // backstageViewTabItem1
            // 
            this.backstageViewTabItem1.Caption = "backstageViewTabItem1";
            this.backstageViewTabItem1.ContentControl = this.backstageViewClientControl1;
            this.backstageViewTabItem1.Name = "backstageViewTabItem1";
            // 
            // tabMain
            // 
            this.tabMain.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 143);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedTabPage = this.homeControl;
            this.tabMain.Size = new System.Drawing.Size(1132, 512);
            this.tabMain.TabIndex = 2;
            this.tabMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.homeControl});
            this.tabMain.CloseButtonClick += new System.EventHandler(this.tabMain_CloseButtonClick);
            this.tabMain.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.tabMain_ControlAdded);
            // 
            // homeControl
            // 
            this.homeControl.Controls.Add(this.backstageMenu);
            this.homeControl.Name = "homeControl";
            this.homeControl.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.homeControl.Size = new System.Drawing.Size(1126, 484);
            this.homeControl.Text = "Trang chủ";
            // 
            // backstageViewControl2
            // 
            this.backstageViewControl2.Controls.Add(this.backstageViewClientControl2);
            this.backstageViewControl2.Items.Add(this.backstageViewTabItem2);
            this.backstageViewControl2.Location = new System.Drawing.Point(71, 214);
            this.backstageViewControl2.Name = "backstageViewControl2";
            this.backstageViewControl2.Size = new System.Drawing.Size(480, 150);
            this.backstageViewControl2.TabIndex = 7;
            // 
            // backstageViewClientControl2
            // 
            this.backstageViewClientControl2.Location = new System.Drawing.Point(188, 0);
            this.backstageViewClientControl2.Name = "backstageViewClientControl2";
            this.backstageViewClientControl2.Size = new System.Drawing.Size(292, 150);
            this.backstageViewClientControl2.TabIndex = 1;
            // 
            // backstageViewTabItem2
            // 
            this.backstageViewTabItem2.Caption = "backstageViewTabItem2";
            this.backstageViewTabItem2.ContentControl = this.backstageViewClientControl2;
            this.backstageViewTabItem2.Name = "backstageViewTabItem2";
            // 
            // printContent
            // 
            this.printContent.DefaultContentPanel = this.recentStackPanel2;
            this.printContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printContent.Location = new System.Drawing.Point(0, 0);
            this.printContent.MainPanel = this.recentStackPanel1;
            this.printContent.Name = "printContent";
            this.printContent.SelectedTab = null;
            this.printContent.Size = new System.Drawing.Size(990, 390);
            this.printContent.TabIndex = 0;
            this.printContent.Title = "In";
            // 
            // recentStackPanel1
            // 
            this.recentStackPanel1.Name = "recentStackPanel1";
            // 
            // recentStackPanel2
            // 
            this.recentStackPanel2.Name = "recentStackPanel2";
            // 
            // btnPdf
            // 
            this.btnPdf.Caption = "PDF";
            this.btnPdf.ImageOptions.ItemNormal.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPdf.ImageOptions.ItemNormal.SvgImage")));
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(106, 70);
            // 
            // exportContent
            // 
            this.exportContent.DefaultContentPanel = this.recentStackPanel4;
            this.exportContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exportContent.Location = new System.Drawing.Point(0, 0);
            this.exportContent.MainPanel = this.recentStackPanel3;
            this.exportContent.Name = "exportContent";
            this.exportContent.SelectedTab = this.recentTabItem1;
            this.exportContent.Size = new System.Drawing.Size(990, 390);
            this.exportContent.TabIndex = 0;
            this.exportContent.Title = "Export";
            // 
            // recentStackPanel3
            // 
            this.recentStackPanel3.Items.AddRange(new DevExpress.XtraBars.Ribbon.RecentItemBase[] {
            this.recentTabItem1});
            this.recentStackPanel3.Name = "recentStackPanel3";
            this.recentStackPanel3.SelectedItem = this.recentTabItem1;
            // 
            // recentStackPanel4
            // 
            this.recentStackPanel4.Name = "recentStackPanel4";
            // 
            // recentStackPanel5
            // 
            this.recentStackPanel5.Caption = "Export type";
            this.recentStackPanel5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("recentStackPanel5.ImageOptions.SvgImage")));
            this.recentStackPanel5.Items.AddRange(new DevExpress.XtraBars.Ribbon.RecentItemBase[] {
            this.recentButtonItem1,
            this.recentButtonItem2});
            this.recentStackPanel5.Name = "recentStackPanel5";
            this.recentStackPanel5.ShowCaption = false;
            // 
            // recentTabItem1
            // 
            this.recentTabItem1.Caption = "Export type";
            this.recentTabItem1.ImageOptions.ItemNormal.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("recentTabItem1.ImageOptions.ItemNormal.SvgImage")));
            this.recentTabItem1.Name = "recentTabItem1";
            this.recentTabItem1.TabPanel = this.recentStackPanel5;
            // 
            // recentButtonItem1
            // 
            this.recentButtonItem1.Caption = "PDF";
            this.recentButtonItem1.ImageOptions.ItemNormal.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("recentButtonItem1.ImageOptions.ItemNormal.SvgImage")));
            this.recentButtonItem1.Name = "recentButtonItem1";
            this.recentButtonItem1.Size = new System.Drawing.Size(106, 70);
            // 
            // recentButtonItem2
            // 
            this.recentButtonItem2.Caption = "XLS";
            this.recentButtonItem2.ImageOptions.ItemNormal.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("recentButtonItem2.ImageOptions.ItemNormal.SvgImage")));
            this.recentButtonItem2.Name = "recentButtonItem2";
            this.recentButtonItem2.Size = new System.Drawing.Size(104, 70);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 686);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.backstageViewControl1);
            this.Controls.Add(this.backstageViewControl2);
            this.Controls.Add(this.ribbonMenu);
            this.Name = "MainForm";
            this.Ribbon = this.ribbonMenu;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Ứng dụng quản lý cân";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageMenu)).EndInit();
            this.backstageMenu.ResumeLayout(false);
            this.PrintTab.ResumeLayout(false);
            this.ExportTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).EndInit();
            this.backstageViewControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.homeControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl2)).EndInit();
            this.backstageViewControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.printContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportContent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonMenu;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonSetting;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnProducts;
        private DevExpress.XtraBars.BarButtonItem btnUnit;
        private DevExpress.XtraBars.BarButtonItem btnEditInfo;
        private DevExpress.XtraBars.BarButtonItem btnInfo;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonHelp;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraTab.XtraTabControl tabMain;
        private DevExpress.XtraTab.XtraTabPage homeControl;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem1;
        private DevExpress.XtraBars.BarButtonItem btnHome;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageMenu;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl PrintTab;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl ExportTab;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem Print;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem3;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl2;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl2;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem2;
        private DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator backstageViewItemSeparator1;
        private DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator backstageViewItemSeparator2;
        private DevExpress.XtraBars.Ribbon.RecentItemControl printContent;
        private DevExpress.XtraBars.Ribbon.RecentStackPanel recentStackPanel2;
        private DevExpress.XtraBars.Ribbon.RecentStackPanel recentStackPanel1;
        private DevExpress.XtraBars.Ribbon.RecentItemControl exportContent;
        private DevExpress.XtraBars.Ribbon.RecentStackPanel recentStackPanel4;
        private DevExpress.XtraBars.Ribbon.RecentButtonItem btnPdf;
        public DevExpress.XtraBars.Ribbon.RecentStackPanel recentStackPanel3;
        private DevExpress.XtraBars.Ribbon.RecentTabItem recentTabItem1;
        private DevExpress.XtraBars.Ribbon.RecentStackPanel recentStackPanel5;
        private DevExpress.XtraBars.Ribbon.RecentButtonItem recentButtonItem1;
        private DevExpress.XtraBars.Ribbon.RecentButtonItem recentButtonItem2;
    }
}