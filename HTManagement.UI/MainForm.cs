using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraTab;
using HTManagement.UI.Service;
using HTManagerment.Data.Common;

namespace HTManagement.UI
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tabMain_CloseButtonClick(object sender, EventArgs e)
        {
            tabMain.TabPages.RemoveAt(tabMain.SelectedTabPageIndex);
            tabMain.SelectedTabPageIndex = tabMain.TabPages.Count - 1;
        }

        private void tabMain_ControlAdded(object sender, ControlEventArgs e)
        {
            tabMain.SelectedTabPageIndex = tabMain.TabPages.Count - 1;
        }

        private void AddTabControl(UserControl userControl, string itemTabName, string icon)
        {
            bool flag = false;
            foreach (XtraTabPage tabItem in tabMain.TabPages)
            {
                if (tabItem.Text == itemTabName)
                {
                    flag = true;
                    tabMain.SelectedTabPage = tabItem;
                }
            }

            if (flag == false)
            {
                var addTab = new AddTabService();
                addTab.AddTabControl(tabMain, itemTabName, icon, userControl);
            }
            userControl.Dock = DockStyle.Fill;
        }

        private void btnProducts_ItemClick(object sender, ItemClickEventArgs e)
        {
            ProductManagerControl productManagerControl = new ProductManagerControl();
            AddTabControl(productManagerControl, CommonConstant.Product, "Product_16x16.png");
        }

        private void btnUnit_ItemClick(object sender, ItemClickEventArgs e)
        {
            var unitManagerControl = new UnitManagerControl();
            AddTabControl(unitManagerControl, CommonConstant.Unit, "RulerHorizontal_16x16.png");
        }

        private void btnEditInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            var basicInfo = new BasicInfoManagerControl();
            AddTabControl(basicInfo, CommonConstant.BasicInfo, "Information_16x16.png");
        }

        private void btnInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            var info = new InfomationControl();
            AddTabControl(info, CommonConstant.SoftwareInfo, "Info_16x16.png");
        }

        private void btnHome_ItemClick(object sender, ItemClickEventArgs e)
        {
            var home = new HomeControl();
            AddTabControl(home, CommonConstant.Home, "Home_16x16.png");}}
}