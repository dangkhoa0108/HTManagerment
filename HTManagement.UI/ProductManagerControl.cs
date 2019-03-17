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

            gvProduct.DataSource = GetDataSource();
            BindingList<ProductModel> dataSource = GetDataSource();
            gvProduct.DataSource = dataSource;
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvProduct.ShowRibbonPrintPreview();
        }
        public BindingList<ProductModel> GetDataSource()
        {
            var data = ProductService.GetProduct();
            BindingList<ProductModel> result = new BindingList<ProductModel>(data);
            return result;
        }
    }
}
