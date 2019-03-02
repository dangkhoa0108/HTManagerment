using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraTab;
using HTManagement.UI.Service;

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
        }

        private void btnProducts_ItemClick(object sender, ItemClickEventArgs e)
        {
            ProductManagerControl productManagerControl = new ProductManagerControl();
            AddTabControl(productManagerControl, "Sản phẩm", "Product_16x16.png");
        }
    }
}