using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraTab;

namespace HTManagement.UI.Service
{
    class AddTabService
    {
        public void AddTabControl(XtraTabControl xtraTabControl, string xtraItemName, string icon, UserControl userControl)
        {
            var xtraTabPage = new XtraTabPage
            {
                Name = "Test",
                Text = xtraItemName,
                Image = Image.FromFile(@"..\..\Icons\" + icon),
                Dock = DockStyle.Fill
            };
            xtraTabPage.Controls.Add(userControl);
            xtraTabControl.TabPages.Add(xtraTabPage);
        }
    }
}
