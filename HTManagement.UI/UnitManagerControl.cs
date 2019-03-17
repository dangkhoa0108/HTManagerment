using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using HTManagerment.Data.BusinessLogic;
using HTManagerment.Data.Model;

namespace HTManagement.UI
{
    public partial class UnitManagerControl : XtraUserControl
    {
        public UnitManagerControl()
        {
            InitializeComponent();
            LoadData();
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            girdUnit.ShowRibbonPrintPreview();
        }

        public BindingList<UnitModel> GetDataSource()
        {
            var data = UnitService.GetUnit();
            BindingList<UnitModel> result = new BindingList<UnitModel>(data);
            return result;
        }

        private void LoadData()
        {
            if (UnitService.GetUnit().Count == 0)
            {
                bbiEdit.Enabled = false;
                bbiDelete.Enabled = false;
            }
            else
            {
                bbiEdit.Enabled = true;
                bbiDelete.Enabled = true;
            }
            BindingList<UnitModel> dataSource = GetDataSource();
            girdUnit.DataSource = dataSource;
            bsiRecordsCount.Caption = "RECORDS : " + dataSource.Count;
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xoá dòng dữ liệu đang chọn?", "Cảnh báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rowIndex = gvUnit.FocusedRowHandle;
                var col = "UnitId";
                var value = gvUnit.GetRowCellValue(rowIndex, col);
                if (value != null)
                {
                    var rs = UnitService.DeleteUnit((int)value);
                    if (rs)
                    {
                        XtraMessageBox.Show("Đã xoá thành công", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        XtraMessageBox.Show("Không thể xoá", "Lỗi", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            UnitUpdateForm frmUnitUpdateForm = new UnitUpdateForm();
            frmUnitUpdateForm.ShowDialog();
            LoadData();
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            int rowIndex = gvUnit.FocusedRowHandle;
            var col = "UnitId";
            var value = gvUnit.GetRowCellValue(rowIndex, col);
            if (value != null)
            {
                UnitUpdateForm updateForm = new UnitUpdateForm();
                updateForm.Id = (int) value;
                updateForm.ShowDialog();
                LoadData();
            }
        }
    }
}
