using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using HTManagerment.Data.BusinessLogic;
using HTManagerment.Data.Model;

namespace HTManagement.UI
{
    public partial class ProductManagerControl : XtraUserControl
    {
        public ProductManagerControl()
        {
            InitializeComponent();

            gridControl.DataSource = GetDataSource();
            BindingList<UnitModel> dataSource = GetDataSource();
            gridControl.DataSource = dataSource;
            bsiRecordsCount.Caption = "RECORDS : " + dataSource.Count;
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }
        public BindingList<UnitModel> GetDataSource(){
            var data = UnitService.GetUnit();
            BindingList<UnitModel> result = new BindingList<UnitModel>(data);
            
            return result;
        }
    }
}
